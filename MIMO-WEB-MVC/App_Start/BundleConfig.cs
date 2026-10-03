using System.Web.Optimization;

namespace MIMOWEB_ENG_NEW
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/jquery")
                    .Include("~/Scripts/jquery-{version}.js")
            );

            bundles.Add(
                new ScriptBundle("~/bundles/jqueryval")
                    .Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js"
                    )
            );

            bundles.Add(
                new ScriptBundle("~/bundles/modernizr")
                    .Include("~/Scripts/modernizr-*")
            );

            bundles.Add(
                new StyleBundle("~/Content/css")
                    .Include("~/Content/bootstrap.mod.css")
            );

            bundles.Add(
                new ScriptBundle("~/bundles/bootstrap")
                    .Include("~/Scripts/bootstrap.mod.js")
            );
        }
    }
}