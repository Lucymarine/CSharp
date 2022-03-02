namespace _2_SqlTabloManuel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CreatTable = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_SutunAdi = new System.Windows.Forms.TextBox();
            this.txt_SutunAdi2 = new System.Windows.Forms.TextBox();
            this.txt_VeriTipi = new System.Windows.Forms.TextBox();
            this.txt_VeriTipi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CreatTable
            // 
            this.btn_CreatTable.Location = new System.Drawing.Point(100, 123);
            this.btn_CreatTable.Name = "btn_CreatTable";
            this.btn_CreatTable.Size = new System.Drawing.Size(182, 29);
            this.btn_CreatTable.TabIndex = 0;
            this.btn_CreatTable.Text = "Tablo Oluştur";
            this.btn_CreatTable.UseVisualStyleBackColor = true;
            this.btn_CreatTable.Click += new System.EventHandler(this.btn_CreatTable_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(15, 82);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(79, 20);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Tablo Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 27);
            this.textBox1.TabIndex = 2;
            // 
            // txt_SutunAdi
            // 
            this.txt_SutunAdi.Location = new System.Drawing.Point(392, 75);
            this.txt_SutunAdi.Name = "txt_SutunAdi";
            this.txt_SutunAdi.Size = new System.Drawing.Size(146, 27);
            this.txt_SutunAdi.TabIndex = 3;
            // 
            // txt_SutunAdi2
            // 
            this.txt_SutunAdi2.Location = new System.Drawing.Point(392, 108);
            this.txt_SutunAdi2.Name = "txt_SutunAdi2";
            this.txt_SutunAdi2.Size = new System.Drawing.Size(146, 27);
            this.txt_SutunAdi2.TabIndex = 4;
            // 
            // txt_VeriTipi
            // 
            this.txt_VeriTipi.Location = new System.Drawing.Point(556, 75);
            this.txt_VeriTipi.Name = "txt_VeriTipi";
            this.txt_VeriTipi.Size = new System.Drawing.Size(166, 27);
            this.txt_VeriTipi.TabIndex = 5;
            // 
            // txt_VeriTipi2
            // 
            this.txt_VeriTipi2.Location = new System.Drawing.Point(556, 108);
            this.txt_VeriTipi2.Name = "txt_VeriTipi2";
            this.txt_VeriTipi2.Size = new System.Drawing.Size(166, 27);
            this.txt_VeriTipi2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sutun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Veri Tipi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_VeriTipi2);
            this.Controls.Add(this.txt_VeriTipi);
            this.Controls.Add(this.txt_SutunAdi2);
            this.Controls.Add(this.txt_SutunAdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btn_CreatTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CreatTable;
        private Label lblTable;
        private TextBox textBox1;
        private TextBox txt_SutunAdi;
        private TextBox txt_SutunAdi2;
        private TextBox txt_VeriTipi;
        private TextBox txt_VeriTipi2;
        private Label label1;
        private Label label2;
    }
}