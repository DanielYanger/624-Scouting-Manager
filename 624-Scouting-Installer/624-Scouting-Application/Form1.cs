using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;

namespace _624_Scouting_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        //Python Engine
        ProcessStartInfo psi = new ProcessStartInfo();

        //Folder Browser
        OpenFileDialog ofd = new OpenFileDialog();

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
                devicePath.Text = ofd.FileName;
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
                    var folder_path = @devicePath.Text;
                    //String path = @"D:\Documents\GitHub\624-Scouting\624-Scouting-Installer\624-Scouting-Application\merging.py";
                    String path = @Application.StartupPath + @"\merging.py";
                    string arg;
                    if (radioButton1.Checked)
                    {
                         arg = string.Format(" \"{0}\" \"{1}\" {2}", path, folder_path, true);
                    }
                    
                    else
                    {
                         arg = string.Format(" \"{0}\" \"{1}\" {2}", path, folder_path, false);
                    }
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
                    if (results.Contains("yeet"))
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
                MessageBox.Show("Error: Something went wrong. Please ensure everything is correct and try again. \n" + ex.ToString());
            }
        }

        private async void importButton_Click(object sender, EventArgs e)
        {

            // start the waiting animation
            pictureBox2.Visible = true;

            // simply start and await the loading task
            importButton.Enabled = false;
            await Task.Run(() => btnImport_Click());

            // re-enable things
            importButton.Enabled = true;
            pictureBox2.Visible = false;
        }

        private async void scheduleGeneratorButton_Click(object sender, EventArgs e)
        {
            // start the waiting animation
            pictureBox4.Visible = true;

            // simply start and await the loading task
            importButton.Enabled = false;
            await Task.Run(() => Schedule());

            // re-enable things
            importButton.Enabled = true;
            pictureBox4.Visible = false;
        }

        private void Schedule()
        {
           
            string schedule = GetSchedule(eventCodeText.Text).GetAwaiter().GetResult();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\schedule.txt";
            Console.WriteLine(path);
            System.IO.File.WriteAllText(@path, schedule);
            MessageBox.Show("Success. The schedule can be found on your desktop.");


        }

        public class Match
        {
            public string comp_level { get; set; }
            public int match_number { get; set; }
            public Alliances alliances { get; set; }
        }

        public class MatchSorter : Comparer<Match>
        {
            public override int Compare(Match x, Match y)
            {
                return x.match_number.CompareTo(y.match_number);
            }
        }

        public class Alliances
        {
            public Alliance red { get; set; }
            public Alliance blue { get; set; }
        }

        public class Alliance
        {
            public List<string> team_keys { get; set; }
        }


        static async Task<string> GetSchedule(string eventCode)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.thebluealliance.com/api/v3/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-TBA-Auth-Key", "b19JEnA7OC6MKFQboTBIOMfHPuGm7lTo15thl1i08fkThnSON14oN36VtDUlsCsn");
            string finalScheulde = "";

            try
            {
                HttpResponseMessage response = await client.GetAsync("event/" + eventCode + "/matches/simple");
                if(response.IsSuccessStatusCode)
                {
                    var jsonFile = await response.Content.ReadAsAsync<List<Match>>();
                    jsonFile.Sort(new MatchSorter());
                    foreach(Match match in jsonFile)
                    {
                        if(match.comp_level=="qm")
                        {
                            string match_number = "Match " + match.match_number+",";
                            
                            foreach(string team in match.alliances.red.team_keys)
                            {
                                string temp = match_number + team.Substring(3) + ";";
                                finalScheulde += temp;
                            }
                            foreach (string team in match.alliances.blue.team_keys)
                            {
                                string temp = match_number + team.Substring(3) + ";";
                                finalScheulde += temp;
                            }
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Big oof");
            }
            return finalScheulde;

        }

        private void PythonEngineLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImportMatchDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // start the waiting animation
            pictureBox3.Visible = true;

            // simply start and await the loading task
            team_list_button.Enabled = false;
            await Task.Run(() => TeamList());

            // re-enable things
            team_list_button.Enabled = true;
            pictureBox3.Visible = false;
        }

        private void TeamList()
        {

            string teamList = GetTeamList(textBox1.Text).GetAwaiter().GetResult();
            Console.WriteLine(teamList);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\teamList.txt";
            System.IO.File.WriteAllText(@path, teamList);
            MessageBox.Show("Success. The team list can be found on your desktop.");

        }


        public class Team
        {
            public int team_number { get; set; }
        }

        static async Task<string> GetTeamList(string eventCode)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.thebluealliance.com/api/v3/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-TBA-Auth-Key", "b19JEnA7OC6MKFQboTBIOMfHPuGm7lTo15thl1i08fkThnSON14oN36VtDUlsCsn");
            string finalTeamList = "TEAM LIST;";

            try
            {
                HttpResponseMessage response = await client.GetAsync("event/" + eventCode + "/teams/simple");
                if (response.IsSuccessStatusCode)
                {
                    var jsonFile = await response.Content.ReadAsAsync<List<Team>>();
                    foreach (Team team in jsonFile)
                    {
                        finalTeamList += team.team_number+";";
                    }
                }
            }
            catch
            {
                Console.WriteLine("Big oof");
            }
            return finalTeamList;

        }

    }
}
