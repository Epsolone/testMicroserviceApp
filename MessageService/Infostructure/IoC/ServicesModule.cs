using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MessageService.Infostructure.Contract;
using Ninject.Modules;
using Ninject.Web.Common;

namespace MessageService.Infostructure.IoC
{
	public class ServicesModule: NinjectModule
	{
		public override void Load()
		{
			this.Bind<IMessageService>().To<Service.MessageService>().InRequestScope();
		}
	}
}