using System;
using Microsoft.Win32;


namespace GetAppsApplication
{
    class GetApps
    {
        static void Main(string[] args)
        {

            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key);

            if (key == null)
            {
                Console.WriteLine("null");
                return;
            }
            var keynames = key.GetSubKeyNames();
            foreach (string subkey_name in keynames)
            {
                using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                {
                    string name = subkey.GetValue("DisplayName", null) as string;
                    string path = subkey.GetValue("DisplayIcon", null) as string;
                    string location = subkey.GetValue("InstallLocation", null) as string;
                    Console.WriteLine("{0}::{1}::{2};", name, path, location);
                }

            }
        }
    }
}