using System.Web;
using System.Web.Optimization;

namespace WebApp
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(
				new StyleBundle("~/bundles/css")
					.Include(
						"~/Content/css/bootstrap.min.css",
						"~/Content/css/font-awesome.min.css",
						"~/Content/css/main.css",
						"~/Scripts/libs/multiple-select/multiple-select.min.css")
				);

			bundles.Add(
				new ScriptBundle("~/bundles/libs")
					.Include(
						"~/Scripts/libs/angular/angular.min.js",
						"~/Scripts/libs/angular/angular-route.min.js",
						"~/Scripts/libs/angular/angular-resource.min.js",
						"~/Scripts/libs/angular/jquery-1.10.2.min.js",
						"~/Scripts/libs/lodash.js",
						"~/Scripts/libs/multiple-select/multiple-select.js")
				);

			bundles.Add(
				new ScriptBundle("~/bundles/app")
					.Include("~/Scripts/app/app.js")
					.IncludeDirectory("~/Scripts/app/controllers", "*.js", true)
					.IncludeDirectory("~/Scripts/app/services", "*.js", true)
					.IncludeDirectory("~/Scripts/app/constant", "*.js", true)
				);
		}
	}
}
