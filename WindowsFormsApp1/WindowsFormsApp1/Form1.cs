using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class cherv : PictureBox
    {
        //червячок класс
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GameStart_Click(object sender, EventArgs e)
        {
            GameStart.Visible = false;
            label1.Visible = true;
            WindVelo.Visible = true;
        }
    }
}
