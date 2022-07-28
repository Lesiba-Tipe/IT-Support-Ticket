using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Ticket_System
{
    public partial class Host : Form
    {
        public static Panel panel = new Panel();
        public Host()
        {
            InitializeComponent();
            //AutoSize = true;
            InitializePanel();

            Controls.Add(panel);
            panel.Controls.Add(new Login());
            
        }

        private void InitializePanel()
        {
            panel.Location = new System.Drawing.Point(4, 13);
            //panel.Location = new Point((this.Width / 2) - (panel.Width / 2), (this.Height / 2) - (panel.Height / 2));
            panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            //panel.Size = new System.Drawing.Size(771, 472);
            panel.AutoSize = true;
           //panel.BackColor = Color.FromArgb(51, 125, 88);
        }
    }
}
