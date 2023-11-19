using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExp_IsTakipProjesi.Formlar;

namespace DevExp_IsTakipProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartmanlar frm = new FrmDepartmanlar();
            if (frm == null)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
