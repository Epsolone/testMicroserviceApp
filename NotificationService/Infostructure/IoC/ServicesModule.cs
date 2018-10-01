using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NotificationService.Infostructure.Contract;
using Ninject.Modules;
using Ninject.Web.Common;

namespace NotificationService.Infostructure.IoC
{
	public class ServicesModule: NinjectModule
	{
		public override void Load()
		{
			this.Bind<INotificationService>().To<Service.NotificationService>().InRequestScope();
		}
	}
}