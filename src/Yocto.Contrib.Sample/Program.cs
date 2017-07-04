using System;

namespace Yocto.Contrib.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string errmsg = "";


            // Get access to your device, connected locally on USB for instance
            YAPI.RegisterHub("usb", ref errmsg);
            var a = YLightSensor.FirstLightSensor();

            // Hot-plug is easy: just check that the device is online
            if (a.isOnline())
            {
                var b = a.get_currentValue();
                
            }
        }
    }
}