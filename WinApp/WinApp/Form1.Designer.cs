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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnsimple = new System.Windows.Forms.RadioButton();
            this.rdbtnVariable = new System.Windows.Forms.RadioButton();
            this.rdbuttonOndeli = new System.Windows.Forms.RadioButton();
            this.rdbtnPaypal = new System.Windows.Forms.RadioButton();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(88, 72);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(55, 16);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(248, 72);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(36, 16);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_invnum
            // 
            this.lbl_invnum.AutoSize = true;
            this.lbl_invnum.Location = new System.Drawing.Point(463, 72);
            this.lbl_invnum.Name = "lbl_invnum";
            this.lbl_invnum.Size = new System.Drawing.Size(112, 16);
            this.lbl_invnum.TabIndex = 2;
            this.lbl_invnum.Text = "Inventory Number";
            // 
            // lbl_objname
            // 
            this.lbl_objname.AutoSize = true;
            this.lbl_objname.Location = new System.Drawing.Point(88, 144);
            this.lbl_objname.Name = "lbl_objname";
            this.lbl_objname.Size = new System.Drawing.Size(86, 16);
            this.lbl_objname.TabIndex = 3;
            this.lbl_objname.Text = "Object Name";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(85, 209);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(41, 16);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(250, 209);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 16);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(88, 103);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(116, 22);
            this.txt_num.TabIndex = 6;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(251, 103);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(127, 22);
            this.txt_date.TabIndex = 7;
            // 
            // txt_invnum
            // 
            this.txt_invnum.Location = new System.Drawing.Point(466, 103);
            this.txt_invnum.Name = "txt_invnum";
            this.txt_invnum.Size = new System.Drawing.Size(151, 22);
            this.txt_invnum.TabIndex = 8;
            // 
            // txt_objname
            // 
            this.txt_objname.Location = new System.Drawing.Point(88, 173);
            this.txt_objname.Name = "txt_objname";
            this.txt_objname.Size = new System.Drawing.Size(482, 22);
            this.txt_objname.TabIndex = 9;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(88, 254);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(116, 22);
            this.txt_count.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(253, 252);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(125, 22);
            this.txt_price.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(371, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 36);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(517, 306);
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
            this.dgv.Location = new System.Drawing.Point(37, 348);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(835, 259);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Payment";
            // 
            // rdbtnsimple
            // 
            this.rdbtnsimple.AutoSize = true;
            this.rdbtnsimple.Location = new System.Drawing.Point(24, 21);
            this.rdbtnsimple.Name = "rdbtnsimple";
            this.rdbtnsimple.Size = new System.Drawing.Size(70, 20);
            this.rdbtnsimple.TabIndex = 17;
            this.rdbtnsimple.TabStop = true;
            this.rdbtnsimple.Text = "Simple";
            this.rdbtnsimple.UseVisualStyleBackColor = true;
            // 
            // rdbtnVariable
            // 
            this.rdbtnVariable.AutoSize = true;
            this.rdbtnVariable.Location = new System.Drawing.Point(24, 47);
            this.rdbtnVariable.Name = "rdbtnVariable";
            this.rdbtnVariable.Size = new System.Drawing.Size(79, 20);
            this.rdbtnVariable.TabIndex = 18;
            this.rdbtnVariable.TabStop = true;
            this.rdbtnVariable.Text = "Variable";
            this.rdbtnVariable.UseVisualStyleBackColor = true;
            // 
            // rdbuttonOndeli
            // 
            this.rdbuttonOndeli.AutoSize = true;
            this.rdbuttonOndeli.Location = new System.Drawing.Point(21, 27);
            this.rdbuttonOndeli.Name = "rdbuttonOndeli";
            this.rdbuttonOndeli.Size = new System.Drawing.Size(98, 20);
            this.rdbuttonOndeli.TabIndex = 19;
            this.rdbuttonOndeli.TabStop = true;
            this.rdbuttonOndeli.Text = "On Delivery";
            this.rdbuttonOndeli.UseVisualStyleBackColor = true;
            // 
            // rdbtnPaypal
            // 
            this.rdbtnPaypal.AutoSize = true;
            this.rdbtnPaypal.Location = new System.Drawing.Point(21, 49);
            this.rdbtnPaypal.Name = "rdbtnPaypal";
            this.rdbtnPaypal.Size = new System.Drawing.Size(71, 20);
            this.rdbtnPaypal.TabIndex = 20;
            this.rdbtnPaypal.TabStop = true;
            this.rdbtnPaypal.Text = "Paypal";
            this.rdbtnPaypal.UseVisualStyleBackColor = true;
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Items.AddRange(new object[] {
            "Regular",
            "Original",
            "Used",
            "HighCopy"});
            this.chkList.Location = new System.Drawing.Point(743, 173);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(129, 89);
            this.chkList.TabIndex = 21;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(755, 283);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 22;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(445, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 20);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Is Avaliable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbtnsimple);
            this.groupBox1.Controls.Add(this.rdbtnVariable);
            this.groupBox1.Location = new System.Drawing.Point(743, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 81);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdbuttonOndeli);
            this.groupBox2.Controls.Add(this.rdbtnPaypal);
            this.groupBox2.Location = new System.Drawing.Point(740, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 67);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.chkList);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.RadioButton rdbtnPaypal;
        private System.Windows.Forms.RadioButton rdbuttonOndeli;
        private System.Windows.Forms.RadioButton rdbtnVariable;
        private System.Windows.Forms.RadioButton rdbtnsimple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

