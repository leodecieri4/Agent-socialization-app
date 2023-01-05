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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            sup sage = new sup();
            vlcControl1.Play(new Uri(sage.shoot(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\U.mp4")));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sup sage = new sup();
            vlcControl1.Play(new Uri(sage.die(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\P.mp4")));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sup sage = new sup();
            vlcControl1.Play(new Uri(sage.talk(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\T.mp4")));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sup sage = new sup();
            vlcControl1.Play(new Uri(sage.heal(@"C:\Users\yusuf\OneDrive\Masaüstü\valorant z\R.mp4")));
        }
    }
}
