(function (app) {
	'use strict';

	app.service('messageService', ['$q', '$location', '$resource', function ($q, $location, $resource) {
		var me = this;

		var API = $resource(
		    'http://localhost:2738/api/Message',
		    {},
		    {
		    	getMessageStatus: {
		    		method: "GET"
		    	},
		    	sendMessage: {
		    		method: "POST"
		    	}
		    }
	    );

		me.getMessageStatus = function (messageId) {
			return API.getMessageStatus({ messageId: messageId }).$promise
			    .then(function (data) {
			    	return data;
			    });
		};

		me.sendMessage = function (model) {
			return API.sendMessage(model).$promise
			    .then(function (data) {
			    	return data;
			    });
		};

	}]);

})(MessageApp);
