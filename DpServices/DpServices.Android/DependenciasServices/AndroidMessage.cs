using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DpServices.Droid.DependenciasServices;
using Xamarin.Forms;

[assembly:Dependency(typeof(AndroidMessage))]

namespace DpServices.Droid.DependenciasServices
{
    public class AndroidMessage : IPlatMessage
    {
        public string GetMessage()
        {
            return "Estoy desde android";
        }
    }
}