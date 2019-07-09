using System.Web;
using System.Web.Optimization;

namespace MVCStarter
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Admin LTE 3 bootstrap Script
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Vendor/plugins/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Vendor/dist/js/adminlte.min.js",
                      "~/Vendor/dist/js/demo.js"

                      ));

            //Admin LTE 3 bootstrap Script Notification
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Vendor/plugins/datatables/jquery.dataTables.min.js",
                      "~/Scripts/notify.min.js",
                      "~/Scripts/nanobar.min.js"
                      ));

            //Admin LTE 3 bootstrap CSS 
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Vendor/plugins/datatables/jquery.dataTables.min.css",
                      "~/Vendor/dist/css/adminlte.min.css",
                      "~/Content/site.css"));


        }
    }
}
