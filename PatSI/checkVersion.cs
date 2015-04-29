using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatSI
{
    public partial class checkVersion : Form
    {
        public checkVersion()
        {
            InitializeComponent();
        }

        private void checkVersion_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            timer1.Enabled = true;
        }

        private void lnkUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            //System.Threading.Thread.Sleep(1000 * 5);
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                UPServer.PatSISvsSoapClient ws = new UPServer.PatSISvsSoapClient();
                string[] vsinfo = ws.getLastVersion().Split('|');
                if (Program.Version.ToUpper() != vsinfo[0].ToUpper())
                {
                    panel2.Visible = true;
                    lnkUrl.Text = vsinfo[0].ToUpper();
                    lnkUrl.Links.Add(new LinkLabel.Link() { LinkData = vsinfo[1] });

                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
