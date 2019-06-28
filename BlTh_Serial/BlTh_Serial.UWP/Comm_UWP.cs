using Xamarin.Forms;

[assembly: Dependency(typeof(BlTh_Serial.UWP.Comm_UWP))]
namespace BlTh_Serial.UWP
{
    public class Comm_UWP : IComm
    {
        public string Comm()
        {
            return "Comm Port Opened!!";
        }
    }


}