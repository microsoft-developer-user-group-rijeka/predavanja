import React from 'react';

import { StackNavigator } from 'react-navigation';

import Exercise1 from './Exercise1';
import Exercise2 from './Exercise2';

const RootStack = StackNavigator({
  Home: {
    screen: Exercise1,
  },
  Todo: {
    screen: Exercise2,
  },
}, {
  initialRouteName: 'Home',
});


// component exported from App.js is entry/root component from which every other component descends
// it's often useful to have more control over the root component than you would get from exporting StackNavigator
export default class Exercise3 extends React.Component {
  constructor(args) {
    super(args);
  }
  render() {
    return <RootStack />;
  }
}
