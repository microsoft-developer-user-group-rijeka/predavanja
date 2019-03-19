import React from 'react';
import { StyleSheet, Text, View, Linking, ScrollView, Image } from 'react-native';

// Exercise 1: Core Components
// View, ScrollView, Image, Text

export default class Exercise1 extends React.Component {
  static navigationOptions = {
    title: 'Home',
  };
  openUrl = (url) => {
    Linking.canOpenURL(url).then(supported => {
      if (supported) {
        Linking.openURL(url);
      } else {
        console.log(`Don't know how to open ${url}.`);
      }
    });
  }
  handleTwitter = () => {
    this.openUrl('https://twitter.com/devug_ri');
  }
  handleGithub = () => {
    this.openUrl('https://github.com/microsoft-developer-user-group-rijeka');
  }
  render() {
    let twitter = <Text style={[styles.red, styles.link]} onPress={this.handleTwitter}>twitter</Text>;
    let github = <Text style={[styles.red, styles.link]} onPress={this.handleGithub}>github</Text>;
    let todo = '';
    if (this.props.navigation) {
      todo = <Text style={[styles.red, styles.link]} onPress={() => this.props.navigation.navigate('Todo')}>todo</Text>;
    };

    return (
      <View style={styles.box}>
        <ScrollView>
          <Image
            source={require('./img/0bit.png')}
            style={styles.icon}
          />
          <Image
            source={{ uri: 'https://partner.fitner.co/apple-touch-icon.png' }}
            style={styles.icon} 
          />
          <Text style={styles.baseText}>
            <Text style={styles.red}>Exercise01</Text>
            Bacon ipsum dolor amet hamburger picanha brisket strip steak shank chuck turkey leberkas flank. Bresaola andouille rump drumstick boudin. Short ribs brisket pork flank, porchetta cow kielbasa. Tenderloin ham hock pig {twitter} beef jerky. Tri-tip beef flank, tongue strip steak fatback capicola. Shank andouille rump prosciutto, boudin tenderloin jowl tail burgdoggen bacon chuck capicola pork tongue. 
            Jerky venison strip steak, fatback landjaeger chuck kevin pancetta chicken. Pancetta bacon jowl meatball kevin venison pork chop porchetta alcatra boudin turkey salami short loin landjaeger spare ribs. Tenderloin alcatra  loin, corned {github} beef jowl ham hock beef beef ribs tail shank prosciutto pork chop short loin kielbasa turducken. Andouille leberkas  pig hamburger beef pancetta venison landjaeger t-bone buffalo.
            Bresaola bacon jerky porchetta. Frankfurter pork loin doner {todo} biltong pork, pig short loin porchetta cow. Salami hamburger venison ball tip porchetta tenderloin ribeye swine t-bone short ribs. Leberkas shankle boudin cupim, spare ribs hamburger andouille sausage ball tip salami. Pork chop doner short ribs, pancetta drumstick rump burgdoggen ham hock meatloaf pastrami corned beef chuck jerky leberkas. 🥓🥓🥓
          </Text>
        </ScrollView>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  box: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  icon: {
    width: 64,
    height: 64,
  },
  baseText: {
    fontSize: 24,
    fontWeight: 'bold',
  },
  red: {
    color: '#f00',
  },
  link: {
    textDecorationLine: 'underline',
  }
});

