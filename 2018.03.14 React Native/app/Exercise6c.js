
import React from 'react';

import { StyleSheet, View, Text, TouchableOpacity, TouchableWithoutFeedback, Animated, Easing, Image } from 'react-native';

// https://color.adobe.com/explore/?filter=most-popular&time=month
// https://medium.com/reactnative/background-images-in-react-native-191f3ed95a45
// http://tenshiikisu.tumblr.com/post/79015021080/heres-my-collection-of-pixel-backgrounds-tile


const ICON_SIZE = 48;
const COLORS = [ '#0024FF', '#005BFF', '#0091FF', '#00C8FF', '#00FEFF' ];

class Exercise6c extends React.Component {
  getRow = n => {
    let squares = [];
    for (let i = 0; i < n; i++) {
      squares.push(<Square key={i} />);
    }
    return (
      <View style={styles.row}>
        {squares}
      </View>
    );
  }

  render() {
    let source = {
      uri: 'https://78.media.tumblr.com/1061954fcd7cb725dae4b956662e45f2/tumblr_inline_mns74aF5iR1qz4rgp.gif'
      
      //'https://78.media.tumblr.com/7ea3f864e3ff8434d8a875a514496242/tumblr_inline_n258vlhuLn1qhwjx8.png'
      //'https://78.media.tumblr.com/fad4cee4c34914dd33c2204c09cf7668/tumblr_inline_mqvlarhoKt1qz4rgp.gif'
      
    };
    let resizeMode = 'repeat'; // repeat | stretch

    return (
      <View style={styles.screen} >
        <View style={{ position: 'absolute', top: 0, left: 0, width: '100%', height: '100%' }}>
          <Image style={{ flex: 1, resizeMode }} source={source} />
        </View>
        <View style={styles.container}>
          <View style={styles.row}></View>
          {this.getRow(5)}
          {this.getRow(5)}
          {this.getRow(5)}
          {this.getRow(5)}
          {this.getRow(5)}
          {this.getRow(5)}
          <View style={styles.row}></View>
        </View>
      </View>
    );
  }
}

class Square extends React.Component {
  state = {
    level: COLORS.length,
    opacity: new Animated.Value(1),
    size: new Animated.Value(ICON_SIZE)
  };
  handlePress = () => {
    let { level, opacity, size } = this.state;
    let newOpacity = level * (1 / COLORS.length);
    if (level > 0) {
      let newLevel = level - 1;
      this.setState({ level: newLevel });
      if (newLevel < 1) {
        Animated.timing(
          opacity,
          { toValue: newOpacity, duration: 800, easing: Easing.linear }
        ).start();
        return;
      }
      Animated.parallel([
        Animated.timing(
          opacity,
          { toValue: newOpacity, duration: 400, easing: Easing.linear }
        ),
        Animated.sequence([
          Animated.timing(
            size,
            { toValue: ICON_SIZE + 4, duration: 200, easing: Easing.bounce }
          ),
          Animated.timing(
            size,
            { toValue: ICON_SIZE, duration: 200, easing: Easing.ease }
          )]
        )
      ]).start();
    }
  }
  render() {
    let { level, opacity, size } = this.state;
    let backgroundColor = COLORS[level - 1];
    return (
      <TouchableWithoutFeedback onPress={this.handlePress}>
        <Animated.View style={[
          styles.box, {
            backgroundColor,
            opacity,
            width: size,
            height: size,
          }]}>
        </Animated.View>
      </TouchableWithoutFeedback>
    );
  }
}

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    backgroundColor: '#000'
  },
  container: {
    flex: 1,
    justifyContent: 'space-around',
    alignItems: 'center',
    //backgroundColor: '#020325', //'#4ED6D6',
  },
  row: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    alignItems: 'center'
  },
  box: {
    width: ICON_SIZE,
    height: ICON_SIZE,
    borderRadius: 32,
    margin: 10
  }
});


export default Exercise6c;