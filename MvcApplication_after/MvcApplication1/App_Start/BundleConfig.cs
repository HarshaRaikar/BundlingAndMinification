using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcApplication1
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
		            .Include("~/Content/styles.css")
            .Include("~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/mordernizer")
                .Include("~/Scripts/mordernizer-*")
                );


            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/Scripts/jquery*")
                .Include("~/Scripts/mustache.js")
                .Include("~/Scripts/bootstrap.js")
                );

            BundleTable.EnableOptimizations = true;
        }

    }
}