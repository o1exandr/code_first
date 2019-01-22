namespace code_first
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Назва товару";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(13, 47);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(29, 13);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Ціна";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Location = new System.Drawing.Point(13, 85);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(53, 13);
            this.lbQty.TabIndex = 0;
            this.lbQty.Text = "Кількість";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(118, 80);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(243, 20);
            this.txtQty.TabIndex = 3;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(160, 118);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(104, 23);
            this.btInsert.TabIndex = 4;
            this.btInsert.Text = "Додати запис";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(270, 118);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(91, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(243, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // AddForm
            // 
            this.AcceptButton = this.btInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtPrice;
    }
}