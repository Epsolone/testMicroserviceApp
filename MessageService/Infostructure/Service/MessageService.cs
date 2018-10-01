using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using AutoMapper;
using Data;
using Data.Models;
using MessageService.Infostructure.Contract;
using MessageService.Infostructure.Model;
using MessageService.ViewModels;

namespace MessageService.Infostructure.Service
{
	public class MessageService: IMessageService
	{
		private IMapper _mapper;
		private readonly string _notificationServiceUrl = $"http://{ConfigurationManager.AppSettings["NotificationServiceUrl"]}";
		private DataProvider _repository;

		public MessageService()
		{
			_repository = new DataProvider();
			var config = new MapperConfiguration(expression =>
			{
				expression.CreateMap<Message, MessageModel>();
			});
			this._mapper = new Mapper(config);
		}

		public MessageModel SendMessage(string subject, string body, List<string> resipients)
		{
			var message = _repository.AddMessage(subject, body, resipients);

			try
			{
				WebClient client = new WebClient();
				var url = _notificationServiceUrl + "?messageId=" + message.Id;
				client.Encoding = System.Text.Encoding.UTF8;
				client.DownloadStringAsync(new Uri(url));
			}
			catch (Exception ex)
			{
				_repository.ChangeMessageStatus(message.Id, false);
			}

			return _mapper.Map<MessageModel>(message);
		}

		public bool CheckMessageStatus(string messageId)
		{
			return _repository.GetMessageById(messageId).IsResultReady;
		}

		public bool GetMessageStatus(string messageId)
		{
			return _repository.GetMessageById(messageId).IsSent;
		}

		public void SetMessageStatus(string messageId, bool status)
		{
			_repository.ChangeMessageStatus(messageId, status);
		}
	}
}