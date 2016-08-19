using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMpPlayer
{
    public partial class Music : Form
    {
       
        Player player = new Player();

        public Music()
        {
            InitializeComponent();

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            infoLabel.Text = openFileDialog1.FileName;
            player.open(openFileDialog1.FileName);

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            player.play();

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.stop();
        }
    }
}
