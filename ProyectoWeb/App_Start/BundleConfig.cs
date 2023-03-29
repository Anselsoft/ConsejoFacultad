using System.Web;
using System.Web.Optimization;

namespace ProyectoWeb
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styles/main_styles.css", "~/Content/styles/responsive.css",
                      "~/Content/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/Site.css"));


            bundles.Add(new StyleBundle("~/Content/PluginsCSS").Include(
                      "~/Content/Plugins/datatables/css/jquery.dataTables.min.css",
                      "~/Content/Plugins/datatables/css/responsive.dataTables.min.css",

                      "~/Content/Plugins/fontawesome-free-5.15.2/css/all.min.css",
                      "~/Content/Plugins/sweetalert2/css/sweetalert.css",

                       "~/Content/Plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                       "~/Content/Plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                       "~/Content/Plugins/OwlCarousel2-2.2.1/animate.css",
                       "~/Content/Plugins/video-js/video-js.css",
                       "~/Content/Plugins/font-awesome-4.7.0/css/font-awesome.min.css",


                      //JQUERY UI
                      "~/Content/Plugins/jquery-ui-1.12.1/jquery-ui.min.css",
                      "~/Content/Plugins/jquery-ui-1.12.1/jquery-ui-timepicker-addon.css",

                       //Bootstrap Duallistbox
                       "~/Content/Plugins/Bootstrap-Duallistbox/css/bootstrap-duallistbox.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/PluginsJS").Include(
                     "~/Content/Plugins/datatables/js/jquery.dataTables.min.js",
                     "~/Content/Plugins/datatables/js/dataTables.responsive.min.js",

                     "~/Content/Plugins/fontawesome-free-5.15.2/js/all.min.js",
                     "~/Content/Plugins/sweetalert2/js/sweetalert.js",

                     //JQUERY UI
                     "~/Content/Plugins/jquery-ui-1.12.1/jquery-ui.min.js",
                     "~/Content/Plugins/jquery-ui-1.12.1/jquery-ui.es.js",

                        //EXPORTAR
                        //"~/Content/js/jquery-3.2.1.min.js",
                        "~/Content/styles/bootstrap4/popper.js",
                        "~/Content/styles/bootstrap4/bootstrap.min.js",
                        "~/Content/plugins/greensock/TweenMax.min.js",
                        "~/Content/plugins/greensock/TimelineMax.min.js",
                        "~/Content/plugins/scrollmagic/ScrollMagic.min.js",
                        "~/Content/plugins/greensock/animation.gsap.min.js",
                        "~/Content/plugins/greensock/ScrollToPlugin.min.js",
                        "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                        "~/Content/plugins/easing/easing.js",
                        "~/Content/plugins/video-js/video.min.js",
                        "~/Content/plugins/video-js/Youtube.min.js",
                        "~/Content/plugins/parallax-js-master/parallax.min.js",
                        "~/Content/js/custom.js",

                     //Bootstrap Duallistbox
                     "~/Content/Plugins/Bootstrap-Duallistbox/js/jquery.bootstrap-duallistbox.min.js",
                     "~/Scripts/jquery.validate.min.js"
                     ));

        }
    }
}
