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
using Xamarin.Forms;

using DpServices.Droid.DependenciasServices;
using Android.Speech.Tts;
using static Android.Speech.Tts.TextToSpeech;

[assembly:Dependency(typeof(AndroidTextAVoz))]
namespace DpServices.Droid.DependenciasServices
{
    public class AndroidTextAVoz : Java.Lang.Object, ITextVoz, IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }


        public void Spek(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}