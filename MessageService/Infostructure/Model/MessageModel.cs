using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageService.Infostructure.Model
{
	public class MessageModel
	{
		public string Id { get; set; }
		public List<string> Recipients { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public bool IsSent { get; set; }
		public bool IsTriedToSend { get; set; }
	}
}