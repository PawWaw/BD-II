using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            MoreInfo mri = new MoreInfo(2);
            mri.ShowDialog();
        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            TopicSet tps = new TopicSet();
            tps.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSection ads = new AddSection();
            ads.ShowDialog();
        }

        private void PresenceButton_Click(object sender, EventArgs e)
        {
            Presences prs = new Presences();
            prs.ShowDialog();
        }
    }
}
