using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace COM3D2_CustomEventEditor.DataClass
{
    public class OfficialNPC
    {
        public string Key { get; set; }
        public string DisplayName { get; set; }

        public static List<OfficialNPC> ReadCSVFile()
        {
            //if translated, update here to load different file
            return ReadCSVFile(Properties.Resources.official_npc_japanese);
        }

        private static List<OfficialNPC> ReadCSVFile(string resFile)
        {
            List<OfficialNPC> result = new List<OfficialNPC>();

            string[] csvRow = resFile.Split('\n');
            //first line is header so we start with i = 1
            for (int i = 1; i < csvRow.Length; i++)
            {
                if (csvRow[i] == "") continue;      //in case empty row
                string[] rowData = csvRow[i].Split(',');

                OfficialNPC item = new OfficialNPC();
                item.Key = rowData[0];
                item.DisplayName = rowData[1];
                result.Add(item);
            }

            return result;
        }
    }
}
