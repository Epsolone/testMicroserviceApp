window.appName = 'MessageApp';
var MessageApp = angular.module(window.appName, ['ngRoute', 'ngResource', 'multipleSelect']);

(function (app, window) {
	'use strict';
	app.config(['$routeProvider', '$locationProvider', '$httpProvider', function ($routeProvider, $locationProvider, $httpProvider) {
		$locationProvider.hashPrefix("");
	}]);
})(MessageApp, window);