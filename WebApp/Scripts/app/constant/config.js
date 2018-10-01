(function (app, window) {
	'use strict';

	app.constant('_', window._)
		.constant('$', window.jQuery);

})(MessageApp, window);