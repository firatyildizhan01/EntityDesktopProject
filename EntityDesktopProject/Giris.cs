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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();
            var sorgu = from x in db.TBLADMIN where x.kullanıcı == textBox1.Text && x.sıfre == textbox2.text select x;
            if (sorgu.any()) ;
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.hide();
            }
            else
            {
                MessageBox.Show("hatalı mesaj");
            }
        }
    }
}
