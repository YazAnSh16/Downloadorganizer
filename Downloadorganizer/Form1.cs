using Microsoft.VisualBasic.ApplicationServices;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Downloadorganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orgnaise_Click(object sender, EventArgs e)
        {

            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                txtPath.Text = folderName;
                //Do your work here!
                MessageBox.Show(folderName);
            }
            
            string path = folderBrowserDialog1.SelectedPath;
            bool root = Directory.Exists(@path);
            string[] files = Directory.GetFiles(@path);
            if (root == true)
            {
                //MessageBox.Show("ee");
                string[] dirs = { "photos", "text", "videos", "programes" , "compressed" ,"sounds" };
                foreach (string dir in dirs)
                {
                    
                    {
                        Directory.CreateDirectory(@path + "\\" + dir);
                        //MessageBox.Show(@path + "\\" + dir);
                    }
                }
                foreach (string file in files)
                {
                    string exe = (Path.GetExtension(file)).ToString();

                    //MessageBox.Show(Path.GetExtension(file));
                    //File.Copy(file, $"{@"C:\Users\yazan\Desktop\test\text\"}{Path.GetFileName(file)}");
                    string[] textExe = { ".txt", ".doc", ".docx", ".rtf", ".odt", ".md" ,".pdf"};

                    if (textExe.Contains(exe))
                    {
                        File.Move(file, $"{path + "\\text\\"}{Path.GetFileName(file)}");
                        
                    }
                    string[] videoExe = { ".mp4", ".mov", ".wmv", ".avi", ".mkv", ".webm", ".flv", ".m4v", ".mpg", ".mpeg", ".m2ts", ".3gp" , ".lrec" };
                    if (videoExe.Contains(exe))
                    {
                        File.Move(file, $"{@path + "\\videos\\"}{Path.GetFileName(file)}");
                    }
                    string[] photoExe = { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
                    if (photoExe.Contains(exe))
                    {
                        File.Move(file, $"{@path + "\\" + "photos\\"}{Path.GetFileName(file)}");
                    }
                    string[] programExe = { ".exe", ".msi" };
                    if (programExe.Contains(exe))
                    {
                        File.Move(file, $"{@path + "\\" + "programes\\"}{Path.GetFileName(file)}");
                    }
                    string[] compressedExe = { ".zip", ".rar", ".7z", ".tar", ".gz", ".bz2" };
                    if (compressedExe.Contains(exe))
                    {
                        File.Move(file, $"{@path + "\\" + "compressed\\"}{Path.GetFileName(file)}");
                    }
                    string[] soundExe = { ".mp3", ".wav", ".aac", ".flac", ".ogg", ".wma", ".m4a" };
                    if(soundExe.Contains(exe))
                    {
                        File.Move(file, $"{@path + "\\" + "sounds\\"}{Path.GetFileName(file)}");
                    }
                }
            }
            else
            {
                MessageBox.Show("folder dosent exist");
            }
        }

        
    }
}
