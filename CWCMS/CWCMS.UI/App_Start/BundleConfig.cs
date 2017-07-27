using System.Web;
using System.Web.Optimization;

namespace CWCMS.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssBundle = new StyleBundle("~/css/");
            cssBundle.Include("~/plugins/bootstrap/bootstrap.css");
            cssBundle.Include("~/plugins/jquery-ui/jquery-ui.min.css");
            cssBundle.Include("~/plugins/fancybox/jquery.fancybox.css");
            cssBundle.Include("~/plugins/fullcalendar/fullcalendar.css");
            cssBundle.Include("~/plugins/xcharts/xcharts.min.css");
            cssBundle.Include("~/plugins/select2/select2.css");
            cssBundle.Include("~/css/style.css");
            bundles.Add(cssBundle);

            var scriptBundler = new ScriptBundle("~/jsplg/");
            scriptBundler.Include("~/plugins/jquery/jquery-2.1.0.min.js");
            scriptBundler.Include("~/plugins/bootstrap/bootstrap.min.js");
            scriptBundler.Include("~/plugins/justified-gallery/jquery.justifiedgallery.min.js");
            scriptBundler.Include("~/plugins/tinymce/tinymce.min.js");
            scriptBundler.Include("~/plugins/tinymce/jquery.tinymce.min.js");
            scriptBundler.Include("~/js/devoops.js");
            bundles.Add(scriptBundler);
        }
    }
}