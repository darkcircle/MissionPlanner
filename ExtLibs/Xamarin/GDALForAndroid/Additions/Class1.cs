using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Java.Util.Logging;
using Org.Apache.Commons.Logging;
using OSGeo.GDAL;
using OSGeo.OGR;
using OSGeo.OSR;

namespace GDALForAndroid.Additions
{
    public class Class1
    {
        public static void test()
        {
            //var driver = new Org.Gdal.Gdal.Driver();

            Gdal.AllRegister();

            var file = "";

            using (var ds = OSGeo.GDAL.Gdal.Open(file))
            {
                //log.InfoFormat("Raster dataset parameters:");
                //log.InfoFormat("  Projection: " + ds.GetProjectionRef());
                //log.InfoFormat("  RasterCount: " + ds.RasterCount);
                //log.InfoFormat("  RasterSize (" + ds.RasterXSize + "," + ds.RasterYSize + ")");

                OSGeo.GDAL.Driver drv = ds.Driver;

                //log.InfoFormat("Using driver " + drv.LongName);

                //string[] metadata = ds.GetMetadata("");
            }


            //Org.Gdal.Ogr.Ogr.Open();
        }
    }
}