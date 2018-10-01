using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NotificationService.Infostructure.Contract;
using NotificationService.ViewModels;

namespace NotificationService.Controllers
{
	[RoutePrefix("api/Notification")]
	public class NotificationController : ApiController
    {
		private readonly INotificationService _notificationService;

		public NotificationController(INotificationService notificationService)
		{
			_notificationService = notificationService;
		}

		public void Get(string messageId)
		{
			_notificationService.SendMessage(messageId);
		}
	}
}
