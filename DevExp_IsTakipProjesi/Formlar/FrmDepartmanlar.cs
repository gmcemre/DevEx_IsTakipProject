﻿using DevExp_IsTakipProjesi.Entity;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExp_IsTakipProjesi.Formlar
{
    public partial class FrmDepartmanlar : Form
    {
        DbIsTakipEntities db = new DbIsTakipEntities();
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void Listeleme()
        {
            try
            {
                var degerler = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.Id,
                                    x.Ad
                                }).ToList();
                gridControl1.DataSource = degerler;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TblDepartmanlar dep = new TblDepartmanlar();
                dep.Ad = txtAd.Text?.Trim();
                db.TblDepartmanlar.Add(dep);
                db.SaveChanges();
                XtraMessageBox.Show("Departman başarılı bir şekilde sisteme eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listeleme();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
