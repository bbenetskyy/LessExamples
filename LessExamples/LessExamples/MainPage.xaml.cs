using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace LessExamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    this.Resources.Add(StyleSheet.FromAssemblyResource(
            //        IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly,
            //        "LessExamples.Styles.MainPage.Android.css"));
            //}
            //else if (Device.RuntimePlatform == Device.iOS)
            //{https://medium.com/@benetskyybogdan/less-with-xamarin-forms-efb9ad76cc1a
            //    this.Resources.Add(StyleSheet.FromAssemblyResource(
            //        IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly,
            //        "LessExamples.Styles.MainPage.iOS.css"));
            //}
            //else
            //{
            //this.Resources.Add(StyleSheet.FromAssemblyResource(
            //    IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly,
            //    "LessExamples.Styles.MainPage.css"));
            //}
        }
    }
}
