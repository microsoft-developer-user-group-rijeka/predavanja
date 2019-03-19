
import React from 'react';

import { StyleSheet, View, Text, TouchableOpacity, TouchableWithoutFeedback, Animated } from 'react-native';

class Exercise6b extends React.Component {

  render() {
    return (
      <View style={styles.container}>
        <View style={styles.row}></View>
        <View style={styles.row}>
          <Square />
          <Square />
          <Square />
          <Square />
          <Square />
        </View>
        <View style={styles.row}>
          <Square />
          <Square />
          <Square />
          <Square />
          <Square />
        </View>
        <View style={styles.row}>
          <Square />
          <Square />
          <Square />
          <Square />
          <Square />
        </View>
        <View style={styles.row}>
          <Square />
          <Square />
          <Square />
          <Square />
          <Square />
        </View>
        <View style={styles.row}></View>
      </View>
    );
  }
}

class Square extends React.Component {
  state = {
    opacity: 1,
    animatedOpacity: new Animated.Value(1)
  };
  handlePress = () => {
    let { opacity } = this.state;
    if (opacity > 0) {
      let newOpacity = opacity - .5;
      Animated.timing(
        this.state.animatedOpacity,
        {
          toValue: newOpacity,
          duration: 400
        }
      ).start();
      this.setState({ opacity: newOpacity });
    }
  }
  render() {
    let {animatedOpacity} = this.state;
    return (
      <TouchableWithoutFeedback onPress={this.handlePress}>
        <Animated.View style={[ styles.box, { opacity: animatedOpacity} ]}></Animated.View>
      </TouchableWithoutFeedback>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'space-around',
    alignItems: 'center'
  },
  row: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    alignItems: 'center'
  },
  box: {
    backgroundColor: '#f00',
    width: 64,
    height: 64,
    borderColor: 'white',
    borderWidth: 2,
    borderRadius: 10
  }
});


export default Exercise6b;