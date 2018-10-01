using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageService.ViewModels
{
	public class GenericResultViewModel<T>
	{
		public T Result { get; set; }
	}
}