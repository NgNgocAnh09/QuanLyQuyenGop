using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuyenGop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(tbTen.Text,cbLoaiHinh.Text,tbSDT.Text,tbEmail.Text,tbMa.Text,cbHinhThuc.Text,tbGiaTri.Text);
            tbTen.Text = "";
            cbLoaiHinh.SelectedIndex = -1;
            tbSDT.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
            tbMa.Text = "";
            cbHinhThuc.SelectedIndex = -1;
            tbGiaTri.Text = "";

        }
    }
}
