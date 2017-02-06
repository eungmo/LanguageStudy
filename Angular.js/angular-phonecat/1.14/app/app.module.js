// Define the 'phonecatApp' module
angular.module('phonecatApp', [
  'ngRoute',
  'ngAnimate',
  // ...which depends on the 'phoneList' module
  'phoneList',
  'phoneDetail',
  'core'
]);