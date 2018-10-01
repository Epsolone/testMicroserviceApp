using NotificationService.ViewModels;

namespace NotificationService.Infostructure.Contract
{
	public interface INotificationService
	{
		void SendMessage(string messageId);
	}
}