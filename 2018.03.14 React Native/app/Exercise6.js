
import React from 'react';

import { StyleSheet, View, Text, TouchableOpacity } from 'react-native';

class Exercise06 extends React.Component {

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
    opacity: 1
  };
  handlePress = () => {
    if (this.state.opacity > 0) {
      this.setState({ opacity: this.state.opacity - .5 });
    }
  }
  render() {
    return (
      <TouchableOpacity onPress={this.handlePress}>
        <View style={[ styles.box, { opacity: this.state.opacity} ]}></View>
      </TouchableOpacity>
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


export default Exercise06;