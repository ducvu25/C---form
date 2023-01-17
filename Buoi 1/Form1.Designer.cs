namespace WinFormsApp1
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
            this.btnKQ = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBieuThuc = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(252, 315);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(94, 29);
            this.btnKQ.TabIndex = 0;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(202, 138);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(180, 27);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new System.EventHandler(this.Ten_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số thứ nhất:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số thứ hai:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(202, 187);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(125, 27);
            this.txtB.TabIndex = 4;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(67, 250);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(94, 29);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(212, 250);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(94, 29);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(356, 250);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(94, 29);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(493, 250);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(94, 29);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(95, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 20);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Biểu thức: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // lblBieuThuc
            // 
            this.lblBieuThuc.AutoSize = true;
            this.lblBieuThuc.Location = new System.Drawing.Point(202, 72);
            this.lblBieuThuc.Name = "lblBieuThuc";
            this.lblBieuThuc.Size = new System.Drawing.Size(78, 20);
            this.lblBieuThuc.TabIndex = 12;
            this.lblBieuThuc.Text = "Biểu thức: ";
            this.lblBieuThuc.Click += new System.EventHandler(this.lblBieuThuc_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(291, 357);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(94, 29);
            this.btnForm2.TabIndex = 13;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 423);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lblBieuThuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnKQ);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKQ;
        private TextBox txtA;
        private Label label1;
        private Label label2;
        private TextBox txtB;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label lbl;
        private Label label3;
        private Label lblBieuThuc;
        private Button btnForm2;
    }
}