using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDesktopProject
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label13.Text = db.TBLKATEGORI.Count().ToString();
            label14.Text = db.TBLURUN.Count().ToString();
            label15.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            label16.Text = db.TBLMUSTERI.Count(X => X.DURUM == false).ToString();
            label19.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            //label22.Text = db.TBLURUN.Sum(z => z.FİYAT).ToString() + "TL";
            label18.Text = (from x in db.TBLURUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            label9.Text =  (from x in db.TBLURUN orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            label20.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label21.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label22.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label24.Text = db.MARKAGETIR().FirstOrDefault();

        }
    }
}
