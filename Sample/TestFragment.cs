using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using ActionSheetCSharp;

namespace Sample
{
    public class TestFragment : ActionSheet
    {

        protected override View OnCreateChildView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.layout1, null);
        }
    }
}