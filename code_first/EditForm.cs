using code_first.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code_first
{
    public partial class EditForm : Form
    {
        public int Id { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Product product)
        {
            InitializeComponent();
            Id = product.Id;
            txtName.Text = product.Name;
            txtPrice.Text = Convert.ToString(product.Price);
            txtQty.Text = Convert.ToString(product.Quantity);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int qty = Convert.ToInt32(txtQty.Text);
                float price = Convert.ToSingle(txtPrice.Text);
                Product product = new Product();
                product.Name = txtName.Text;
                product.Price = price;
                product.Quantity = qty;

                using (EFContext context = new EFContext())
                {
                    var result = context.Products.SingleOrDefault(b => b.Id == Id);
                    if (result != null)
                    {
                        result.Name = product.Name;
                        result.Price = product.Price;
                        result.Quantity = product.Quantity;
                        context.SaveChanges();
                    }
                }

                MessageBox.Show($"Товар {product.Name} оновлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення даних\n\t{ex.Message}", ex.Message);
            }
        }
    }
}
