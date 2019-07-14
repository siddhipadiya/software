using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;


namespace myproject
{
    public partial class scannerpage : Form
    {
        private object listBox;

        public object Scanner { get; private set; }

        public scannerpage()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            datashow c = new datashow();
            c.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            scannerpage.Enabled = false;
            WebClient webClient = new WebClient();
            webClient.OpenReadCompleted += new OpenReadCompletedEventHandler(webClient_openReadCompleted);
            Uri URL = new Uri("http://pinkbike.com/");
            webClient.OpenReadAsync(URL);


        }

        private void webClient_openReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WebClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                const string PATTERN = @"a href=""(?<link>.+)""";
                Regex regex = new Regex(PATTERN, RegexOptions.IgnoreCase);
                TextReader TR = new StreamReader(e.Result);
                string content = TR.ReadToEnd();
                MatchCollection MC = regex.Matches(content);

                foreach (Match match in MC)
                {
                    listBox.Items.Add(match.Groups["link"]);

                }
                TR.Close();

            }
            
        }

        private void NewMethod()
        {
            Scanner.Enabled = true;
        }
    }
}
