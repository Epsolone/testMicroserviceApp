using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using MessageService.Infostructure.Contract;
using MessageService.Infostructure.Model;
using MessageService.Models;
using MessageService.ViewModels;

namespace MessageService.Controllers
{
	[EnableCors(origins: "http://localhost:2564/", headers: "*", methods: "*")]
	public class MessageController : ApiController
	{
		private readonly IMessageService _messageService;

		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}

		public GenericResultViewModel<MessageModel> Post(SendMessageModel model)
		{
			var message = _messageService.SendMessage(model.Subject, model.Body, model.Recipients);
			return new GenericResultViewModel<MessageModel>()
			{
				Result = message
			};
		}

		public void Get(string messageId, bool status)
		{
			_messageService.SetMessageStatus(messageId, status);
		}

		//to avoid this get method need implement for example SignalR logic to bind 
		//to make connection with client side and _notificationService.SendMessage method 
		//and wait for result
		public MessageStatusViewModel Get(string messageId)
		{
			var result = new MessageStatusViewModel()
			{
				IsResultReady = _messageService.CheckMessageStatus(messageId),
				IsSend = false
			};

			if (result.IsResultReady)
			{
				result.IsSend = _messageService.GetMessageStatus(messageId);
			}

			return result;
		}
	}
}
