using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HZS_System
{
    public static class Extentions
    {

        public static string uploads_path = @"C:\Users\Sakit\Desktop\Samir-m-tasks\Form-Final\ZHS_Code_Academy_management\HZS_System\HZS_System\Uploads\";

        public static string getHashCode(string password)
        {
            byte[] data = new System.Text.ASCIIEncoding().GetBytes(password);
            var dataEncrypted = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hashResult = new System.Text.ASCIIEncoding().GetString(dataEncrypted);
            return hashResult;
        }


        public static void Export_data(DataGridView dGV, string filename)
        {
            string stOutput = "";
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}
