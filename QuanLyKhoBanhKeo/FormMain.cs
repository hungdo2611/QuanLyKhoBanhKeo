using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoBanhKeo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            QLNV form = new QLNV();

            form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HangHoa form = new HangHoa();
            form.Show();
        }
    }
}
