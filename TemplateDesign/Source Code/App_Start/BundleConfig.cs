using System.Web;
using System.Web.Optimization;

namespace TemplateDesigning
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            #region User Side

            /*
              <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom fonts for this template -->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>
    <!-- Plugin CSS -->
    <link href="vendor/magnific-popup/magnific-popup.css" rel="stylesheet">
    <!-- Custom styles for this template -->
    <link href="css/creative.min.css" rel="stylesheet">
             */
            bundles.Add(new StyleBundle("~/template/css").Include(
                    "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                    "~/Content/vendor/fontawesome-free/css/all.min.css",
                    "~/Content/vendor/magnific-popup/magnific-popup.css",
                    "~/Content/css/creative.min.css"));




            /*
             

    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Plugin JavaScript -->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
    <script src="vendor/scrollreveal/scrollreveal.min.js"></script>
    <script src="vendor/magnific-popup/jquery.magnific-popup.min.js"></script>
    <!-- Custom scripts for this template -->
    <script src="js/creative.min.js"></script>
             
             */


            bundles.Add(new ScriptBundle("~/template/js").Include(
                                 "~/Content/vendor/jquery/jquery.min.js",
                                 "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                                 "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                                 "~/Content/vendor/scrollreveal/scrollreveal.min.js",
                                 "~/Content/vendor/magnific-popup/jquery.magnific-popup.min.js",
                                 "~/Content/js/creative.min.js"));



            #endregion

            //admin template


            /*
             
    <!-- Bootstrap Core CSS -->
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- MetisMenu CSS -->
    <link href="../vendor/metisMenu/metisMenu.min.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="../dist/css/sb-admin-2.css" rel="stylesheet">
    <!-- Morris Charts CSS -->
    <link href="../vendor/morrisjs/morris.css" rel="stylesheet">
    <!-- Custom Fonts -->
    <link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
             
             */

            bundles.Add(new StyleBundle("~/adminTemplate/css").Include(
                      "~/Content/admin/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/admin/vendor/metisMenu/metisMenu.min.css",
                      "~/Content/admin/dist/css/sb-admin-2.css",
                      "~/Content/admin/vendor/morrisjs/morris.css",
                      "~/Content/admin/vendor/font-awesome/css/font-awesome.min.css"));










            /*
            



    <!-- jQuery -->
    <script src="../vendor/jquery/jquery.min.js"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="../vendor/bootstrap/js/bootstrap.min.js"></script>
    <!-- Metis Menu Plugin JavaScript -->
    <script src="../vendor/metisMenu/metisMenu.min.js"></script>
    <!-- Morris Charts JavaScript -->
    <script src="../vendor/raphael/raphael.min.js"></script>
    <script src="../vendor/morrisjs/morris.min.js"></script>
    <script src="../data/morris-data.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="../dist/js/sb-admin-2.js"></script>
             
             */

            bundles.Add(new ScriptBundle("~/adminTemplate/js").Include(
                        "~/Content/admin/vendor/jquery/jquery.min.js",
                        "~/Content/admin/vendor/bootstrap/js/bootstrap.min.js",
                        "~/Content/admin/vendor/metisMenu/metisMenu.min.js",
                        "~/Content/admin/vendor/raphael/raphael.min.js",
                        "~/Content/admin/vendor/morrisjs/morris.min.js",
                        "~/Content/admin/data/morris-data.js",
                        "~/Content/admin/dist/js/sb-admin-2.js"));

        }
    }
}
