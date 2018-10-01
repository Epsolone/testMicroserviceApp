using System.Collections.Generic;

namespace MessageService.Models
{
	public class SendMessageModel
	{
		public List<string> Recipients { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}