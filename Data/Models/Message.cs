using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
	public class Message
	{
		public string Id { get; set; }
		public List<string> Recipients { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public bool IsSent { get; set; }
		public bool IsResultReady { get; set; }
	}
}
