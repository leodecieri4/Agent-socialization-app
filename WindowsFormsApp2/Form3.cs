using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            duelists neon = new duelists();
            vlcControl1.Play(new Uri(neon.shoot(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\E.mp4")));

        }

        private void label4_Click(object sender, EventArgs e)
        {
            duelists neon = new duelists();
            vlcControl1.Play(new Uri(neon.die(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\H.mp4")));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            duelists neon = new duelists();
            vlcControl1.Play(new Uri(neon.talk(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\F.mp4")));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            duelists neon = new duelists();
            vlcControl1.Play(new Uri(neon.dash(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\G.mp4")));
        }
    }
}
