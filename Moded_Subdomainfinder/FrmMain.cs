using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Moded_Subdomainfinder
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn_execute_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_website.Text))
            {
                listView1.Items.Clear();

                lbl_status.ForeColor = Color.Black;
                lbl_status.Text = "Status: None";

                txt_logs.Clear();
                Task.Factory.StartNew(() => { StartScan(); });

            }
        }

        private void StartScan()
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    var result = GetSubdomains(txt_website.Text);

                    if (result.Ex != null || result.Message != "Success")
                    {
                        String s = "";

                        if (result.Ex != null)
                            s += result.Ex.Message;

                        lbl_status.ForeColor = Color.DarkRed;
                        lbl_status.Text = "Status: " + result.Message + " [ " + s + " ] ";

                        return;
                    }
                    else
                    {
                        lbl_status.ForeColor = Color.Green;
                        lbl_status.Text = "Status: " + result.Message;
                    }

                    txt_logs.Text = result.Raw;

                    //Add subdomains to listview
                    foreach (var i in result.Subdomains)
                    {
                        var item = new ListViewItem(new String[] { i.Url, i.IP });
                        listView1.Items.Add(item);
                    }
                });
            }));

            t.IsBackground = true;
            t.Start();
        }

        private GetSubdomainResult GetSubdomains(String url)
        {
            try
            {
                var subdomains = new List<Subdomain>();
                var client = new RestClient("https://api.hackertarget.com/hostsearch/?q=" + url);
                var req = new RestRequest(Method.GET);
                var raw_text = "";

                var response = client.Get(req);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    String content = response.Content;
                    var lines = content.Split('\n');

                    foreach (var i in lines)
                    {
                        try
                        {
                            var spl = i.Split(',');
                            subdomains.Add(new Subdomain() { Url = spl[0], IP = spl[1] });
                            raw_text += $"{spl[0]}{Environment.NewLine}{spl[1]}{Environment.NewLine}--------------------{Environment.NewLine}";
                        }
                        catch { }
                    }

                    if (subdomains.Count == 0)
                    {
                        return new GetSubdomainResult() { Ex = null, Message = "Subdomains is empty.", Subdomains = null };
                    }

                    return new GetSubdomainResult() { Ex = null, Message = "Success", Subdomains = subdomains, Raw = raw_text };
                }
                else
                {
                    return new GetSubdomainResult() { Ex = null, Message = "Status code is " + response.StatusCode.ToString(), Subdomains = null };
                }
            }
            catch (Exception ex)
            {
                return new GetSubdomainResult() { Ex = ex, Message = "Exception", Subdomains = null };
            }
        }

        private void Btn_copyAll_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_logs.Text))
                return;
            try
            {
                Clipboard.SetText(txt_logs.Text);
                MessageBox.Show("Copied", "Copy subdomain logs !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Failed to copy subdomain logs !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Btn_saveAs_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_logs.Text))
                return;

            var sfd = new SaveFileDialog() { Filter = "TXT Files (*.txt)|*.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sfd.FileName, txt_logs.Text);
                    MessageBox.Show("Saved", "Saved subdomain logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Failed to save subdomain logs !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
