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
            label15.Text = db.TBLMUSTERI.Count(X => X.DURUM == false).ToString();
        }
    }
}
