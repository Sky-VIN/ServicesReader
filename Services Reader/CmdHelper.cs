using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System;


namespace ServicesReader
{
    class CmdHelper
    {
        private int automaticDelayedCount = 0;
        private int automaticCount = 0;
        private int manualCount = 0;
        private int disabledCount = 0;
        private int unknownCount = 0;

        public string Generate(string fileName, List<ListViewItem> list)
        {
            string container = "";

            foreach (ListViewItem item in list)
            {
                /* appending services */
                container += GenerateServiceScript(item.SubItems[0].Text, item.SubItems[1].Text) + "\n";

                /* counting types */
                if (item.SubItems[1].Text.Equals(Resources.Type_AutoDelayed)) automaticDelayedCount++;
                if (item.SubItems[1].Text.Equals(Resources.Type_Auto)) automaticCount++;
                if (item.SubItems[1].Text.Equals(Resources.Type_Manual)) manualCount++;
                if (item.SubItems[1].Text.Equals(Resources.Type_Disabled)) disabledCount++;
                if (item.SubItems[1].Text.Equals(Resources.Type_Unknown)) unknownCount++;
            }

            /* filling file header */
            string head = String.Format(Resources.FileHead,
                System.DateTime.Now.ToString(),
                list.Count,
                automaticDelayedCount,
                automaticCount,
                manualCount,
                disabledCount,
                unknownCount);

            ResetCounters(); // in case repeated generation

            /* writing into file */
            try
            {
                StreamWriter sWriter = new StreamWriter(fileName);
                sWriter.WriteLine(head + "\n");
                sWriter.WriteLine(container);
                sWriter.WriteLine(Resources.RestartQuestion);
                sWriter.Close();
            }
            catch (System.Exception e) { return e.Message; }

            return null;
        }


        private string GenerateServiceScript(string serviceName, string startupType)
        {
            return "sc config \"" + serviceName + "\" start= " +
                startupType
                .Replace(Resources.Type_AutoDelayed, "delayed-auto")
                .Replace(Resources.Type_Auto, "auto")
                .Replace(Resources.Type_Manual, "demand")
                .Replace(Resources.Type_Disabled, "disabled")
                .Replace(Resources.Type_Unknown, "disabled");
        }


        private void ResetCounters()
        {
            automaticDelayedCount = 0;
            automaticCount = 0;
            manualCount = 0;
            disabledCount = 0;
            unknownCount = 0;
        }
    }
}
