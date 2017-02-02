// Register 'phoneList' component, along with its associated controller and template
angular.module('phoneList').component('phoneList', {
  templateUrl: 'phone-list/phone-list.template.html',
  controller: function PhoneListController2() {
    this.phones = [
      {
        name: 'Nexus S',
        snippet: 'Fast just got faster with Nexus S.'
      }, {
        name: 'Motorola XOOM with wi-fi',
        snippet: 'The Next, Next Generation tablet.'
      }, {
        name: 'Motorola XOOM',
        snippet: 'The Next, Next Generation tablet.'
      }
    ];
  }
});