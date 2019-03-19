# React Native

## O predavanju

U posljednje tri godine [React Native](https://facebook.github.io/react-native/) je prošao trnovit put od nepotpunog koncepta do vrlo raširene tehnologije za izradu višeplatformskih mobilnih aplikacija. Iako pisanje višeplatformskih rješenja u JavaScriptu nije nikakva novost, React Native je specifičan utoliko što je konačan proizvod 'punokrvna' aplikacija u kojoj se korisničko sučelje ne krije unutar web preglednika unutar aplikacije već iscrtava od nativnih komponenti.

React Native se konceptualno i tehnološki uvelike oslanja na [React](https://reactjs.org/) i moderan JavaScript ekosustav, pa tako predstavlja prirodan sljedeći korak web developerima zainteresiranim za ulazak u svijet mobilnih aplikacija. Na predavanju ćemo pokriti ključne koncepte i načine razmišljanja, te biblioteke i alate potrebne za izradu vaše prve React Native aplikacije (te izraditi jednu), a zatim ići u dubinu ili širinu ovisno o željama i predznanju auditorija.

[Tin](https://twitter.com/tinc2k) je programski inženjer specijaliziran u području web aplikacija, s raznolikim iskustvom vođenja razvojnih timova i pisanja koda za konzultantske kuće, korporativne klijente i istraživačke institute iz SAD-a i Europe. Trenutno radi iz Rijeke za njujorški startup [Playbook](https://playbookapp.io).

## Projekt - primjeri s predavanja

Projekt je inicijaliziran koristeći [Create React Native App](https://github.com/react-community/create-react-native-app). Za *debugging* aplikacije na iOS ili Android uređaju, na uređaj instalirajte [Expo](https://expo.io), te navigirajte u `app` poddirektorij iz komandne linije. Tamo je potrebno instalirati pakete, pokrenuti projekt i pratiti instrukcije za vaš uređaj:

```
npm install
npm start
```

Aplikacija bi se trebala osvježiti prilikom svake promjene datoteka unutar projektnog direktorija. Entry point aplikacije je datoteka App.js, a zamjenom naziva komponente u render() metodi moguće je proći kroz sve primjere:

```
export default class App extends React.Component {
  render() {
    return <Exercise0 />
  }
}
```

## Slajdovi

### Big Picture

- JavaScript
  - ES6+
  - npm
- React
  - props
  - state, setState()
  - JSX
  - render() & virtual DOM
  - component lifecycle
- HTML5
  - flexbox
  - fetch
- React Native
  - ?

### ES6+

- let, const
- for...of, for...in for  
  `for (let x of items) {...}`
- arrow functions =>
  `let records = list.find(r => r.id === id);`
- classes
  `class Hello extends React.Component {...}`
- async/await
  `let records = await store.fetchRecords(id);`
- array & object spread syntax
  `<Component {...this.props} />`
- destructuring
  `const {a, b, c} = obj;`
- modules
  `export default class Record extends React.Component {...`
  `import { StyleSheet, Text, View } from 'react-native';`

### React

- declarative -> predictable -> confidence -> reliability
- components
- props
- state, setState()
- render()
  - Virtual DOM
  - [reconciliation](https://reactjs.org/docs/reconciliation.html)
- JSX
- lifecycle
  - mounting: constructor, componentWillMount, **componentDidMount**, render
  - updating: **componentWillReceiveProps**, shouldComponentUpdate, componentWillUpdate, render, componentDidUpdate
  - sub-bullets are for nerds

### Component

```
class Hello extends React.Component {
  constructor(props) {
    super(props);
  }
  render() {
    return <h1>Hello {this.props.name}.</h1>;
  }
}
```

```
function Hello(props) {
  return <h1>{props.name}</h1>;
}
const Hello = (props) => (<h1>Hello {props.name}</h1>);
```

```
class Hello extends React.Component {
  state = { counter: 0 };
  componentDidMount() {
    setInterval(() => this.setState({ counter: this.state.counter + 1 }), 1000);
  }
  render() {
    return (
      <div>
        <h1>Hello {this.props.name}.</h1>
        <p>This screen is open for {this.state.counter} seconds.</p>
      </div>
    );
  }
}
```

### Core Components

- View `<View>{...}</View>`
- [Text](https://facebook.github.io/react-native/docs/text.html) `<Text>Hello.</Text>`
- [Image](http://www.reactnativeexpress.com/image) ` <Image source={require('./logo.png')} style={{width: 64, height: 64}} />`
- TextInput `<TextInput onChangeText={this.handleChangeText} value={this.state.current} />`
- ScrollView `<ScrollView></ScrollView>`
- StyleSheet `const styles = StyleSheet.create({...});`
- FlatList, SectionList, ListView

### Styling & StyleSheet

- dimensions: fixed | flex
- layout
  - flex, flexDirection, justifyContent, alignItems
  - width, height
  - margin, padding
- visual (View)
  - color, backgroundColor
  - borderWidth, borderColor, borderRadius
  - opacity
- visual (Text)
  - fontFamily, fontSize, fontStyle, fontWeight, lineHeight, textAlign…

### Flexbox

- flexDirection
  - column | row
- justifyContent
  - flex-start | center | flex-end | space-around | space-between | space-evenly
- alignItems
  - flex-start | center | flex-end | stretch
- flex: n
- http://www.reactnativeexpress.com/flexbox

### UI, Native & Custom Components

- User Interface
  - Button, Picker, Slider, Switch
- iOS
  - ActionSheetIOS, AlertIOS, DatePickerIOS, ImagePickerIOS, NavigatorIOS, ProgressViewIOS, PushNotificationIOS, SegmentedControlIOS, TabBarIOS
- Android
  - BackHandler, DatePickerAndroid, DrawerLayoutAndroid, PermissionsAndroid, ProgressBarAndroid, TimePickerAndroid, ToastAndroid, ToolbarAndroid, ViewPagerAndroid
- Platform-specific
  - file extensions: Button.ios.js | Button.android.js
  - Platform module: Platform.OS, Platform.select, Platform.Version

### Touch

- Native props
  `<Button onPress={this._onPressButton} title="Press Me" />`
- Touchables
  - TouchableHighlight, TouchableOpacity, TouchableWithoutFeedback

``` 
    <TouchableOpacity onPress={this.handlePress}>
      <View style={styles.article}></View>
    </TouchableOpacity>
```

- Gesture Responder System

### Animation

- Animated API
- LayoutAnimation

```
new Animated.Value(0)
Animated.timing(foo, { toValue: 1, duration: 1000 }).start()
<Animated.View style={{...this.props.style, opacity: fadeAnim }}>
```

### Navigation
- StackNavigator
- route configuration
- nesting
- this.props.navigation

```
let { navigation } = this.props;
navigation.navigate('Details');
navigation.navigate('Details', { id: 15 });
let id = navigation.state.params.id;
```

### Networking

- fetch()

```
const response = await fetch(uri);
const json = await response.json();
```

- XMLHttpRequest
- WebSockets

### Data

- Component State
- Redux
- GraphQL
- Realm

### Thinking in React

1. mock-first
2. break into components
3. build static, stateless version
4. identify state data
5. identify state location
6. add inverse data flows

### Comparison

- Params
  - language
  - ecosystem / community
  - convenience (toolchain, setup & build time, OS/hardware limitations, debugging/profiling)
  - upgradeability, maintainability
- Competition
  - Xamarin
  - Ionic
  - Apache Cordova / PhoneGap

### Pros

- community
- battle-tested: Instagram, Facebook, Tesla, AirBnb, Skype
- iOS dev/debugging bez build/Xcode
- sophisticated gesture handling
- access to native capabilities
- constant updates

### Cons

- ES6+/npm/yarn/React/flexbox/fetch/Animatesjafldsjfsaljlskadsajlkfdsjfl!!!!!1
- constant updates
- npm | yarn
- not pixel perfect
- FIXED toolchain
- FIXED licensing

### Toolchain

- create-react-native-app & Expo
- babel, eslint, flow, watchman, jest, yarn...
- Windows, *nix, macOS
