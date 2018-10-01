using System.Collections.Generic;
using MessageService.Infostructure.Model;
using MessageService.ViewModels;

namespace MessageService.Infostructure.Contract
{
	public interface IMessageService
	{
		MessageModel SendMessage(string subject, string body, List<string> resipients);
		bool CheckMessageStatus(string messageId);
		bool GetMessageStatus(string messageId);
		void SetMessageStatus(string messageId, bool status);
	}
}