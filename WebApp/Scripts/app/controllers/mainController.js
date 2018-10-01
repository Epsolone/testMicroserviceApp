(function (app) {
	'use strict';

	app.controller('mainController', ['$scope', 'messageService', function ($scope, messageService) {

		var newMsg = {
			body: "hello world",
			subject: "test subj",
			recipients: [1, 2, 3]
		};
		messageService.sendMessage(newMsg)
			.then(function(data) {
				debugger;
			}).catch(function(error) {
				debugger;
			});

	}]);
})(MessageApp);
