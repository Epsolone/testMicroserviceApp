using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
	public class DataProvider
	{
		private static List<Message> messagesCollection;

		public DataProvider()
		{
			if(messagesCollection == null)
				messagesCollection = new List<Message>();
		}

		public Message AddMessage(string subject, string body, List<string> resipients)
		{
			var newMessage = new Message()
			{
				Id = Guid.NewGuid().ToString(),
				Body = body,
				Subject = subject,
				Recipients = resipients
			};

			messagesCollection.Add(newMessage);
			return newMessage;
		}

		public void ChangeMessageStatus(string messageId, bool status)
		{
			var message = messagesCollection.First(x => x.Id == messageId);
			message.IsSent = status;
			message.IsResultReady = true;
		}

		public Message GetMessageById(string messageId)
		{
			var message = messagesCollection.First(x => x.Id == messageId);
			return message;
		}
	}
}
