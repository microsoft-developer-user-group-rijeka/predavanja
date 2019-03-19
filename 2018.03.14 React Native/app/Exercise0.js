import React, { Component } from 'react';
import { StyleSheet, View, Text } from 'react-native';

// Exercise 0: Basic Component
// class, initial state, lifecycle

export default class Hello extends Component {
  state = { counter: 0 };
  componentDidMount() {
    setInterval(() => this.setState({ counter: this.state.counter + 1 }), 1000);
  }
  render() {
    return (
      <View>
        <Text>Hello, {this.props.name}.</Text>
        <Text>This screen is open for {this.state.counter} seconds.</Text>
      </View>
    );
  }
}
