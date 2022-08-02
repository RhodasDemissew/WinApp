namespace WinApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_invnum = new System.Windows.Forms.Label();
            this.lbl_objname = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_invnum = new System.Windows.Forms.TextBox();
            this.txt_objname = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(75, 37);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(55, 16);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(254, 37);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(36, 16);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_invnum
            // 
            this.lbl_invnum.AutoSize = true;
            this.lbl_invnum.Location = new System.Drawing.Point(440, 37);
            this.lbl_invnum.Name = "lbl_invnum";
            this.lbl_invnum.Size = new System.Drawing.Size(112, 16);
            this.lbl_invnum.TabIndex = 2;
            this.lbl_invnum.Text = "Inventory Number";
            // 
            // lbl_objname
            // 
            this.lbl_objname.AutoSize = true;
            this.lbl_objname.Location = new System.Drawing.Point(75, 106);
            this.lbl_objname.Name = "lbl_objname";
            this.lbl_objname.Size = new System.Drawing.Size(86, 16);
            this.lbl_objname.TabIndex = 3;
            this.lbl_objname.Text = "Object Name";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(75, 181);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(41, 16);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(250, 181);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 16);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(78, 56);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(116, 22);
            this.txt_num.TabIndex = 6;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(253, 56);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(127, 22);
            this.txt_date.TabIndex = 7;
            // 
            // txt_invnum
            // 
            this.txt_invnum.Location = new System.Drawing.Point(443, 56);
            this.txt_invnum.Name = "txt_invnum";
            this.txt_invnum.Size = new System.Drawing.Size(185, 22);
            this.txt_invnum.TabIndex = 8;
            // 
            // txt_objname
            // 
            this.txt_objname.Location = new System.Drawing.Point(78, 137);
            this.txt_objname.Name = "txt_objname";
            this.txt_objname.Size = new System.Drawing.Size(550, 22);
            this.txt_objname.TabIndex = 9;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(78, 211);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(116, 22);
            this.txt_count.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(253, 211);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(125, 22);
            this.txt_price.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(430, 225);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 36);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(526, 225);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(68, 36);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(42, 279);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(716, 163);
            this.dgv.TabIndex = 14;
            // 
            // errorprovider
            // 
            this.errorprovider.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_objname);
            this.Controls.Add(this.txt_invnum);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_objname);
            this.Controls.Add(this.lbl_invnum);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_num);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_invnum;
        private System.Windows.Forms.Label lbl_objname;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_invnum;
        private System.Windows.Forms.TextBox txt_objname;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ErrorProvider errorprovider;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

