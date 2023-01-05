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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            controllers skye = new controllers();
            vlcControl1.Play(new Uri(skye.shoot(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\L.mp4")));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            controllers skye = new controllers();
            vlcControl1.Play(new Uri(skye.die(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\M.mp4")));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            controllers skye = new controllers();
            vlcControl1.Play(new Uri(skye.talk(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\O.mp4")));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            controllers skye = new controllers();
            vlcControl1.Play(new Uri(skye.flash(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\N.mp4")));
        }
    }
}
