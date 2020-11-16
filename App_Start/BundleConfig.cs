using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.js",
                       "~/Scripts/perfect-scrollbar.jquery.min.js",
                       "~/Scripts/sparkline.js"));
            //"~/Content/site.css",
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/style.min.css",
                      "~/Content/util.css",
                      "~/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
                      "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/bundles/js").Include(
                     "~/Scripts/waves.js",
                     "~/Scripts/sidebarmenu.js",
                     "~/Scripts/custom.js",
                     "~/Scripts/excanvas.js",
                     "~/Scripts/jquery.flot.js",
                     "~/Scripts/jquery.flot.pie.js",
                     "~/Scripts/jquery.flot.time.js",
                     "~/Scripts/jquery.flot.stack.js",
                     "~/Scripts/jquery.flot.crosshair.js",
                     "~/Scripts/jquery.flot.tooltip.min.js",
                     "~/Scripts/chart-page-init.js",
                     "~/Scripts/login.js"));
        }
    }
}
