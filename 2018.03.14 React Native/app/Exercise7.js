
// https://facebook.github.io/react-native/docs/network.html
// http://www.reactnativeexpress.com/networking
// https://jsonplaceholder.typicode.com/users
// https://jsonplaceholder.typicode.com/posts

import React, {Component} from 'react';

import { View, Text, ScrollView, StyleSheet, ActivityIndicator } from 'react-native';
 
class Exercise7 extends Component {
  constructor(props){
    super(props);
    this.state = {
      movies: []
    };
  }
  getFeed = async function()  {
    try {
      let response = await fetch('https://facebook.github.io/react-native/movies.json');
      let responseJson = await response.json();
      this.setState({ movies: responseJson.movies });
    } catch (error) {
      console.error(error);
    }
  }
  componentDidMount() {
    this.getFeed();
  }

  render() {
    let items = [];
    if (this.state.movies && this.state.movies.length > 0) {
      items = this.state.movies.map(m => {
        return <Movie key={m.title} title={m.title} year={m.releaseYear} />;
      });
    }
    return (
      <View>
        <ScrollView>
          {items}
        </ScrollView>
      </View>
    );
  }
}

export default Exercise7;

class Movie extends Component {
  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.baseText}>
          <Text>{this.props.title}</Text><Text> ({this.props.year})</Text>
        </Text>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    margin: 10
  },
  baseText: {
    fontSize: 24,
    fontWeight: 'bold',
  },
  year: {
    fontSize: 16,
    fontWeight: 'normal',
  }
});