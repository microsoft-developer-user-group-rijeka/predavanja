module.exports = {
  "env": {
    "browser": true,
    "es6": true,
    "node": true
  },
  "extends": "eslint:recommended",
  "parserOptions": {
    "ecmaVersion": 8, //2017
    "sourceType": "module",
    "ecmaFeatures": {
      "experimentalObjectRestSpread": true,
      "jsx": true
    }
  },
  "plugins": [ "react", "pug" ],
  "rules": {
    "indent": [ "warn", 2 ],
    "quotes": [ "warn", "single", {
      "avoidEscape": true,
      "allowTemplateLiterals": true
    }],
    "semi": [ "error", "always" ],
    "no-console": "off",
    "react/jsx-uses-vars": "warn"
  },
  "globals": {
    "console": true,
    "window": true,
    "alert": true,
    "dialog": true
  }
};