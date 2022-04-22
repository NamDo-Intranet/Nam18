using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        public void loadPB()
        {
            string sql = "select * from PhongBan";
            cbbphongban.DataSource = KetNoi.getData(sql);
            cbbphongban.DisplayMember = "TenPB";
            cbbphongban.ValueMember = "MaPB";
        }
        public void loadData()
        {
            string sql = "select * from NhanVien";
            dtgvshow.DataSource = KetNoi.getData(sql);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadPB();
            loadData();
        }
    }
}
