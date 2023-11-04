using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class MuhasebeForm : Form
    {
        public MuhasebeForm()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void MuhasebeForm_Load(object sender, EventArgs e)
        {
            dgwProductsPurchasing.DataSource = _productDal.GetAllPurchasing();
            dgwProductsSale.DataSource = _productDal.GetAllSale();
        }

        private void dgwProductsPurchasing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            _productDal.AddPurchasing(new Product1
            {
                Urun_Turu = cbxProductType1.SelectedItem.ToString(),
                Satin_Alinan_Miktar = Convert.ToInt32(tbxAmount1.Text),
                Urunun_Satin_Alindigi_Bolge = cbxDistance1.SelectedItem.ToString(),
                Alis_Fiyati = Convert.ToInt32(tbxUnitPrice1.Text),
                Satin_Alma_Tarihi = Convert.ToDateTime(dateTimePicker1.Value)

            });
            dgwProductsPurchasing.DataSource = _productDal.GetAllPurchasing();
            MessageBox.Show("Bilgiler Kaydedildi!");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _productDal.AddSale(new Product2
            {
                Urun_Turu = cbxProductType2.SelectedItem.ToString(),
                Satis_Fiyati = Convert.ToInt32(tbxUnitPrice2.Text),
                Urunun_Satildigi_Bolge = cbxDistance2.SelectedItem.ToString(),
                Satilan_Miktar = Convert.ToInt32(tbxAmount2.Text),
                Satis_Tarihi = Convert.ToDateTime(dateTimePicker2.Value)

            });
            dgwProductsSale.DataSource = _productDal.GetAllSale();
            MessageBox.Show("Bilgiler Kaydedildi!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void MuhasebeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

