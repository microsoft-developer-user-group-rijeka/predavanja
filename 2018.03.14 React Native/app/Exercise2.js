import React from 'react';

import { ScrollView, StyleSheet, Text, TextInput, View } from 'react-native';

export default class Exercise2 extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      current: '',
      focus: false,
      items: [ 'prva stavka', 'druga stavka', 'treca stavka' ]
    };
  }
  static navigationOptions = {
    title: 'TODO',
    headerStyle: {
      backgroundColor: '#f4511e',
    },
    headerTintColor: '#fff',
    headerTitleStyle: {
      fontWeight: 'bold',
    },
  };
  handleChangeText = text => {
    this.setState({
      current: text
    })
  }
  // https://facebook.github.io/react-native/docs/textinput.html#onkeypress
  handleSubmit = () => {
    if (this.state.current.trim().length > 0) {
      let newItems = this.state.items.slice();
      newItems.unshift(this.state.current);
      this.setState({
        current: '',
        items: newItems
      });
    } else {
      //console.log('input is empty.');
    }
  }
  render() {
    let elements = this.state.items.map((item, index) => {
      return (
        <Text style={styles.baseText} key={index}>- {item}</Text>
      );
    });
    return (
      <View style={styles.container}>
        <TextInput
          style={styles.input}
          onChangeText={this.handleChangeText}
          onSubmitEditing={this.handleSubmit}
          value={this.state.current}
          placeholder='Add new...'
          keyboardAppearance='dark'
          autoCapitalize='none'
        />
        <ScrollView style={styles.scroll}>
          {elements}
        </ScrollView>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flexDirection: 'column',
    alignItems: 'stretch',
    alignSelf: 'stretch',
    paddingTop: 30,
    paddingLeft: 5,
    paddingRight: 5
  },
  input: {
    marginBottom: 10,
    color: '#000',
    borderWidth: 2,
    borderColor: '#000',
    height: 40,
    fontSize: 24,
    //backgroundColor: '#daa',
  },
  baseText: {
    fontSize: 24,
    fontWeight: 'bold',
  },
  scroll: {
    //backgroundColor: '#ada'
  },
});