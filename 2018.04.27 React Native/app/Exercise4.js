import React from 'react';

import { StyleSheet, Text, View, Button, Picker, Slider, Switch } from 'react-native';

// exercise 4: UI & native components

export default class Exercise4 extends React.Component {
  constructor(args) {
    super(args);
    this.state = {
      language: 'java'
    };
  }
  handlePress = ev => {
    console.log('event happened', ev);
  }
  render() {
    return (
      <View style={styles.container}>
        <Slider />
        <Text>This is after the slider.</Text>
        <Switch />
        <Text>This is after the switch.</Text>
        <Button
          onPress={this.handlePress}
          title="Learn More"
          color="#841584"
          accessibilityLabel="Learn more about this purple button"
        />
        <Text>This is after the button.</Text>
        <Picker
          selectedValue={this.state.language}
          style={{ height: 50, width: 100 }}
          onValueChange={(itemValue, itemIndex) => this.setState({language: itemValue})}>
          <Picker.Item label="Java" value="java" />
          <Picker.Item label="JavaScript" value="js" />
          <Picker.Item label="C++" value="cpp" />
          <Picker.Item label="C#" value="csharp" />
          <Picker.Item label="Erlang" value="erlang" />
          <Picker.Item label="Go" value="golang" />
          <Picker.Item label="Haskell" value="haskell" />
        </Picker>
        <Text>This is after the picker.</Text>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingTop: 20
  }
});