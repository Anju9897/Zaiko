using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;

namespace CacheManager.CLS
{
    public static class Comandos
    {
        public static void CrearCarpeta(String pCarpeta)
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(@"cd C:\");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(@"MKDIR "+ pCarpeta);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
            catch
            {
                
            }
        }

        public static byte[] conversionImagen(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            return aByte;
        }

        //convertir el arreglo de arrays a imagen
        public static Image retornarImagen(byte[] byteArray)
        {
            Image img = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArray);
                img = Image.FromStream(ms,true);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return img;
        }
        
    }
}
