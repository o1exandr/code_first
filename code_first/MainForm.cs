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
    }
}
