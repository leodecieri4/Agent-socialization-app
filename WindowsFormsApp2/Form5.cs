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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            controllers breach = new controllers();
            vlcControl1.Play(new Uri(breach.shoot(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\İ.mp4")));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            controllers breach = new controllers();
            vlcControl1.Play(new Uri(breach.die(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\J.mp4")));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            controllers breach = new controllers();
            vlcControl1.Play(new Uri(breach.talk(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\K.mp4")));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            controllers breach = new controllers();
            vlcControl1.Play(new Uri(breach.flash(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\I.mp4")));
        }
    }
}
