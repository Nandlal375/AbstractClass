using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace BundleAndMiniFicationInMvc.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            // var bundle = new ScriptBundle("~/bundles/js");
            // bundle.Include("~/Content/JS/javaScript.js", 
            //     "~/Content/JS/javaScript1.js",
            //     "~/Content/JS/javaScript2.js",
            //     "~/Content/JS/javaScript3.js",
            //     "~/Content/JS/javaScript4.js",
            //     "~/Content/JS/javaScript5.js",
            //     "~/Content/JS/javaScript6.js"
            //     );

            //bundles.Add(bundle);
            bundles.Add(new ScriptBundle("~/bundles/js").IncludeDirectory("~/Content/JS", "*.js"));
            bundles.Add(new StyleBundle("~/bundles/CSS").IncludeDirectory("~/Content/Styles", "*.css"));
         BundleTable.EnableOptimizations = true;
        }
    }
}