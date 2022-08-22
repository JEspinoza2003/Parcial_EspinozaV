namespace Parcial_Espinoza.AppWin
{
    partial class frmProductosEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCancel = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.cboStock = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(69, 70);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(244, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(69, 119);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(244, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCancel
            // 
            this.txtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.txtCancel.Location = new System.Drawing.Point(138, 269);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 10;
            this.txtCancel.Text = "Cancelar";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(238, 269);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(75, 23);
            this.txtSave.TabIndex = 11;
            this.txtSave.Text = "Grabar";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // cboStock
            // 
            this.cboStock.FormattingEnabled = true;
            this.cboStock.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.cboStock.Location = new System.Drawing.Point(69, 171);
            this.cboStock.Name = "cboStock";
            this.cboStock.Size = new System.Drawing.Size(244, 21);
            this.cboStock.TabIndex = 12;
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(72, 226);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(241, 21);
            this.cboCat.TabIndex = 13;
            // 
            // frmProductosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.cboStock);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductosEdit";
            this.Text = "frmProductosEdit";
            this.Load += new System.EventHandler(this.frmProductosEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.ComboBox cboStock;
        private System.Windows.Forms.ComboBox cboCat;
    }
}