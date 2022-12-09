using Microsoft.Win32;
using System.Management;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Collections.Generic;


namespace ServicesReader
{
    class ServiceHelper
    {
        private int automaticDelayedCount = 0;
        private int automaticCount = 0;
        private int manualCount = 0;
        private int disabledCount = 0;
        private int unknownCount = 0;

        private const string MAIN_KEY = @"SYSTEM\CurrentControlSet\Services\";
        private ServiceController[] services = ServiceController.GetServices();


        public ListViewItem[] GetServicesList()
        {
            List<ListViewItem> Items = new List<ListViewItem>();

            foreach (ServiceController sc in services)
                Items.Add(new ListViewItem(new string[] { sc.DisplayName, sc.ServiceName, GetStartupType(sc.ServiceName), GetServiceDescription(sc.ServiceName) }));

            return Items.ToArray();
        }


        /* Getting Startup Type from Registry by name */
        private string GetStartupType(string serviceName)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(MAIN_KEY + serviceName);
            switch ((int)key.GetValue("Start"))
            {
                case 2:
                    try
                    {
                        if ((int)key.GetValue("DelayedAutostart") == 1)
                        {
                            automaticDelayedCount++;
                            return Resources.Type_AutoDelayed;
                        }
                        else
                        {
                            automaticCount++;
                            return Resources.Type_Auto;
                        }
                    }
                    catch
                    {
                        automaticCount++;
                        return Resources.Type_Auto;
                    }

                case 3:
                    manualCount++;
                    return Resources.Type_Manual;

                case 4:
                    disabledCount++;
                    return Resources.Type_Disabled;

                default:
                    unknownCount++;
                    return Resources.Type_Unknown;
            }
        }


        /* Getting service description method * https://stackoverflow.com/a/51194227/5521566 */
        private string GetServiceDescription(string serviceName)
        {
            ManagementObject service = new ManagementObject(new ManagementPath(string.Format("Win32_Service.Name='{0}'", serviceName)));
            try { return service["Description"].ToString(); }
            catch (System.Exception) { return null; }
        }


        /* Counters getters */
        public int GetAllServicesCount() { return services.Length; }

        public int GetAutomaticDelayedCount() { return automaticDelayedCount; }

        public int GetAutomaticCount() { return automaticCount; }

        public int GetManualCount() { return manualCount; }

        public int GetDisabledCount() { return disabledCount; }

        public int GetUnknownCount() { return unknownCount; }

        public void ResetCounters()
        {
            automaticDelayedCount = 0;
            automaticCount = 0;
            manualCount = 0;
            disabledCount = 0;
            unknownCount = 0;
        }
    }
}