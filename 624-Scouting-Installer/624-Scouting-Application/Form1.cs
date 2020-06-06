using System;

using System.Diagnostics;
using System.Windows.Forms;


namespace _624_Scouting_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Python Engine
        ProcessStartInfo psi = new ProcessStartInfo();

        //Folder Browser
        FolderBrowserDialog ofd = new FolderBrowserDialog();

        //File Browser
        OpenFileDialog fd = new OpenFileDialog();

        //Python.exe Button
        private void PythonExeButton_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PythonExeText.Text = fd.FileName;
            }
        }

        //Choose Device Butoon
        private void ChooseDeviceButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                devicePath.Text = ofd.SelectedPath;
            }
        }

        private void eventCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void apiKeyLabel_Click(object sender, EventArgs e)
        {

        }

        private void PythonExeText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                psi.FileName = PythonExeText.Text;
                var folder_path = devicePath.Text;
                string arg = string.Format(@"D:\Documents\GitHub\VS-Stuff\624-Scouting\624-Scouting-Installer\624-Scouting-Application\merging.py {0}", folder_path);
                psi.Arguments = arg;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                var errors = "";
                var results = "";
                using (var process = Process.Start(psi))
                {
                    errors = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
                Console.WriteLine(errors);
                if (errors == "")
                {
                    MessageBox.Show("The program successfully executed. The CSV should be on your desktop.");
                }
                else
                {
                    MessageBox.Show("The program did not execute successfully. Please ensure the proper folder is selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something went wrong. Please ensure everything is correct and try again.");
            }
        }

        private void scheduleGeneratorButton_Click(object sender, EventArgs e)
        {
            try
            {
                psi.FileName = PythonExeText.Text;
                var api_key = apiKeyText.Text;
                var event_key = eventCodeText.Text;
                string arg = string.Format(@"D:\Documents\GitHub\VS-Stuff\624-Scouting\624-Scouting-Installer\624-Scouting-Application\Scouting.py {0} {1}", event_key, api_key);
                psi.Arguments = arg;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                var errors = "";
                var results = "";
                using (var process = Process.Start(psi))
                {
                    errors = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
                if (errors=="")
                {
                    MessageBox.Show("The program successfully executed. The schedule can be found on your desktop.");
                }
                else
                {
                    MessageBox.Show("The program did not execute successfully. Double check your API key and event code.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something went wrong. Please ensure everything is correct and try again.");
            }
        }

        private void PythonEngineLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
