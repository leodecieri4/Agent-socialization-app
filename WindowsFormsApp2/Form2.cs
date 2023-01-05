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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            duelists jett = new duelists();
            vlcControl1.Play(new Uri(jett.shoot(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\A.mp4")));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            duelists jett = new duelists();
            vlcControl1.Play(new Uri(jett.die(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\B.mp4")));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            duelists jett = new duelists();
            vlcControl1.Play(new Uri(jett.talk(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\D.mp4")));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            duelists jett = new duelists();
            vlcControl1.Play(new Uri(jett.dash(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\C.mp4")));
        }
    }
}
