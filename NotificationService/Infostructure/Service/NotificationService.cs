using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using Data;
using NotificationService.Infostructure.Contract;
using NotificationService.ViewModels;

namespace NotificationService.Infostructure.Service
{
	public class NotificationService : INotificationService
	{
		private readonly string _messageServiceUrl = $"http://{ConfigurationManager.AppSettings["MessageServiceUrl"]}";

		public void SendMessage(string messageId)
		{
			//next need implement logic to send message and get it status
			//but here now we have hardcode

			Random rnd = new Random();
			var result = rnd.Next(0, 100)%2 == 0;

			try
			{
				WebClient client = new WebClient();
				var url = _messageServiceUrl + "?messageId=" + messageId + "&status=" + result;
				client.Encoding = System.Text.Encoding.UTF8;
				client.DownloadStringAsync(new Uri(url));
			}
			catch(Exception ex)
			{
				var x = "w";
			}
		}
	}
}