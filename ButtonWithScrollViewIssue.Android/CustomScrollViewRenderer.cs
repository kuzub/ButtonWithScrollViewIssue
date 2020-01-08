using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ButtonWithScrollViewIssue.CustomScrollView), typeof(ButtonWithScrollViewIssue.Droid.CustomScrollViewRenderer))]
namespace ButtonWithScrollViewIssue.Droid
{
    public class CustomScrollViewRenderer : ScrollViewRenderer
    {
        //public CustomScrollViewRenderer(Context context) : base(context)
        //{
        //}
    }
}
