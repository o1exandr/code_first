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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
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
                    context.Products.Add(product);
                    context.SaveChanges();
                }

                MessageBox.Show($"Товар {product.Name} додано");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запису даних\n\t{ex.Message}", ex.Message);
            }
        }
    }
}
