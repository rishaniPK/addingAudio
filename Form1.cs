using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace addingAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // addinng a wav audio using resource file
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sndplayer = new SoundPlayer(addingAudio.Properties.Resources.Charging_tone);
                sndplayer.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show ("Error Message" + ex.Message);
            }
        }
    }

}
