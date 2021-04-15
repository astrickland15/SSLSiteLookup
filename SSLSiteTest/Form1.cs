using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSLSiteTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            List<string> unResolvedSites = new List<string>();
            progressBar.Maximum = Sites.Lines.Length;

            if (string.IsNullOrEmpty(Sites.Text))
            {
                MessageBox.Show(string.Format("Please Enter Some Domains."), "Missing Domains");
                    return;
            }

            foreach (var site in Sites.Lines)
            {
                try
                {
                    if (string.IsNullOrEmpty(site))
                    {
                        continue;
                    }
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SecureLink(site));
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    progressBar.Increment(1);
                }
                catch
                {
                    unResolvedSites.Add(site);
                }               
            }
            
            if (unResolvedSites.Count == 0)
            {
                MessageBox.Show(string.Format("Congratulations!  All Sites Resolve."), "Break Out The Champagne");
            }
            var siteList = string.Join(Environment.NewLine, unResolvedSites);

            if (unResolvedSites.Count > 0)
            {
                MessageBox.Show(string.Format("The Following {0} Sites Did Not Resolve: \n\n " + siteList, unResolvedSites.Count), "Summary");
                progressBar.Increment(unResolvedSites.Count);
            }
            AddToTextFile(unResolvedSites);
        }

        public static string SecureLink(string link)
        {
            return "https://www." + link;
        }

        public static void AddToTextFile(List<string> domains)
        {
            using (StreamWriter sw = new StreamWriter(@"c:\testing\UnresolvedSSLDomains.txt"))
            {
                foreach (string domain in domains)
                {
                    sw.WriteLine(domain);
                }
            }
        }
    }
}
