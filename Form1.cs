using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = logicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            logicPersonel.LLPersonleEkle(ent);
            MessageBox.Show("Personel Eklendi...");
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            logicPersonel.LLPersonelSil(ent.Id);
            MessageBox.Show("Personel Silindi...");
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            logicPersonel.LLPersonleGuncelle(ent);
            MessageBox.Show("Personel Güncellendi...");
        }
    }
}
