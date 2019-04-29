using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HKTestapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            var isCrashed = HockeyApp.CrashManager.DidCrashInLastSession;
            Console.Write(isCrashed);
        }

        void Clicked_TrackMe(object sender, System.EventArgs e)
        {
            HockeyApp.MetricsManager.TrackEvent(
    "arshad click Event",
    new Dictionary<string, string> { { "time", DateTime.UtcNow.ToString() } },
    new Dictionary<string, double> { { "valu", 1.0 } }
  );
        }

        void Clicked_CrashMe(object sender, System.EventArgs e)
        {
            throw new Exception();
        }
    }
}
