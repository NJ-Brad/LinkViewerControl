using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            viewerControl1.ShowLink("http://google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewerControl1.ShowLink("http://google.com");

        }
    }
}
