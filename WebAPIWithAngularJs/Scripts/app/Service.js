App.service('APIService', function ($http) {
    this.getSubs = function () {
        return $http.get('API/Subscribers');
    }
});