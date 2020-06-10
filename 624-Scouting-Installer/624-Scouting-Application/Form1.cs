using System;
using System.Threading.Tasks;
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


        private void btnImport_Click()
        {
            try
            {
                psi.FileName = PythonExeText.Text;
                var folder_path = devicePath.Text;
                String path = @Application.StartupPath + @"\merging.py";
                string arg = string.Format(" \"{0}\" {1}", path, folder_path);
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
                if (results.Contains("yeet"))
                {
                    MessageBox.Show("The program successfully executed. The CSV should be on your desktop.");
                }
                else
                {
                    MessageBox.Show("The program did not execute successfully. Please ensure the proper folder is selected. \n" + errors);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something went wrong. Please ensure everything is correct and try again. \n" + ex.ToString());
            }
        }

        private async void importButton_Click(object sender, EventArgs e)
        {

            // start the waiting animation
            Hiding.Visible = false;

            // simply start and await the loading task
            importButton.Enabled = false;
            await Task.Run(() => btnImport_Click());

            // re-enable things
            importButton.Enabled = true;
            Hiding.Visible = true;
        }

        private async void scheduleGeneratorButton_Click(object sender, EventArgs e)
        {
            // start the waiting animation
            pictureBox3.Visible = false;

            // simply start and await the loading task
            importButton.Enabled = false;
            await Task.Run(() => Schedule());

            // re-enable things
            importButton.Enabled = true;
            pictureBox3.Visible = true;
        }

        private void Schedule()
        {
            try
            {
                psi.FileName = PythonExeText.Text;
                var api_key = apiKeyText.Text;
                var event_key = eventCodeText.Text;
                String path = @Application.StartupPath + @"\Scouting.py";
                string arg = string.Format(" \"{0}\" {1} {2}", @path, event_key, api_key);
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
                if (results.Contains("200"))
                {
                    MessageBox.Show("The program successfully executed. The schedule can be found on your desktop. \n" + results);
                }
                else
                {
                    MessageBox.Show("The program did not execute successfully. Double check your API key and event code. \n" + errors);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something went wrong. Please ensure everything is correct and try again. \n" + ex.ToString());
            }
        }

        private void PythonEngineLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
