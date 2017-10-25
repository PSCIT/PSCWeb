using System.Web;
using System.Web.Optimization;

namespace PSCWebsite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;

            //--------------------------- Script Bundles ---------------------------

            var jqueryBundle = new ScriptBundle("~/Scripts/jquery", "https://code.jquery.com/jquery-3.1.1.min.js").Include(
                "~/Scripts/jquery-{version}.js");
            jqueryBundle.CdnFallbackExpression = "window.jquery";
            bundles.Add(jqueryBundle);

            var bootstrapBundle = new ScriptBundle("~/Scripts/bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.2/js/bootstrap.min.js").Include(
                "~/Scripts/bootstrap-{version}.js");
            bootstrapBundle.CdnFallbackExpression = "window.Bootstrap";
            bundles.Add(bootstrapBundle);

            var ModernizrBundle = new ScriptBundle("~/Scripts/Modernizr", "https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js").Include(
               "~/Scripts/modernizr-{version}.js");
            ModernizrBundle.CdnFallbackExpression = "window.Modernizr";
            bundles.Add(ModernizrBundle);

            bundles.Add(new ScriptBundle("~/Scripts/LocalScripts").Include(
                "~/Scripts/site.js")
            );

            //--------------------------- Style Bundles ---------------------------

            var BootstrapStyleBundle = new StyleBundle("~/Content/bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.2/css/bootstrap.min.css").Include(
                "~/Content/bootstrap.min.css");
            bundles.Add(BootstrapStyleBundle);

            bundles.Add(new StyleBundle("~/Content/Stylesheet/LocalStyles").Include(
                "~/Content/Stylesheet/site.css"));

            var FontAwesomeStyleBundle = new StyleBundle("~/Content/Stylesheet/FontAwesome", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css").Include(
                "~/Content/Stylesheet/font-awesome.min.css");
            bundles.Add(FontAwesomeStyleBundle);

            var animateStyleBundle = new StyleBundle("~/Content/Stylesheet/animate", "https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css").Include(
                "~/Content/Stylesheet/animate.min.css");
            bundles.Add(animateStyleBundle);

        }
    }
}