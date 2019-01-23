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

        private void btInsert_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

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
    }
}
