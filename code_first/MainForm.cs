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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // читаємо базу даних
        private void btRead_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            using (EFContext context = new EFContext())
            {
                foreach (var product in context.Products)
                {
                    object[] row =
                       {
                            product.Id, product.Name, product.Price, product.Quantity
                        };
                    dgvProducts.Rows.Add(row);
                }
            }
        }

        // показуємо форму для внесення нової похиції товару
        private void btInsert_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        // зчитуємо обрану позицію і запускаємо форму для внесення змін
        private void btUpdate_Click(object sender, EventArgs e)
        {

            if  (dgvProducts.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];

                Product product = new Product();
                product.Id = Convert.ToInt32(selectedRow.Cells["ColumnId"].Value);
                product.Name = Convert.ToString(selectedRow.Cells["ColumnName"].Value);
                product.Price = Convert.ToSingle(selectedRow.Cells["ColumnPrice"].Value);
                product.Quantity = Convert.ToInt32(selectedRow.Cells["ColumnQty"].Value);

                EditForm editForm = new EditForm(product);
                editForm.ShowDialog();
            }
 
        }

        // видаляємо обрану позицію з Grid'а
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedCells.Count > 0)
            {
                // зчитали обраний рядок
                int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];

                Product product = new Product();
                product.Id = Convert.ToInt32(selectedRow.Cells["ColumnId"].Value);
                product.Name = Convert.ToString(selectedRow.Cells["ColumnName"].Value);
                product.Price = Convert.ToSingle(selectedRow.Cells["ColumnPrice"].Value);
                product.Quantity = Convert.ToInt32(selectedRow.Cells["ColumnQty"].Value);

                // запитуємо чи точно хочеш користувач видалити
                DialogResult dialogResult = MessageBox.Show($"Ви дійсно хочете видалити товар {product.Name}?", "Видалення товару", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) // якщо так - видаляємо
                {
                    try
                    {
                        using (EFContext context = new EFContext())
                        {
                            var result = context.Products.SingleOrDefault(b => b.Id == product.Id);
                            if (result != null)
                            { 
                                context.Products.Remove(result);
                                context.SaveChanges();
                            }
                        }

                        MessageBox.Show($"Товар {product.Name} видалено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка видалення товару {product.Name}\n\t{ex.Message}", ex.Message);
                    }
                    btRead_Click(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // якщо НІ - нічого не робимо
                }
            }
            
        }
    }
}
