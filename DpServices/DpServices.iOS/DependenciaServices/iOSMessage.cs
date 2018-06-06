using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DpServices.iOS.DependenciaServices;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(iOSMessage))]
namespace DpServices.iOS.DependenciaServices
{
    public class iOSMessage : IPlatMessage
    {
        public string GetMessage()
        {
            return "Esto es desde iOS";
        }
    }
}