// Define the 'phonecatApp' module
angular.module('phonecatApp', [
  'ngRoute',
  // ...which depends on the 'phoneList' module
  'phoneList',
  'phoneDetail'
]);