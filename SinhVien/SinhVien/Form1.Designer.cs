
namespace SinhVien
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
            this.lbma = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvshow = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbngaysinh = new System.Windows.Forms.TextBox();
            this.tbtenphong = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btchon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpktime = new System.Windows.Forms.DateTimePicker();
            this.cbbphongban = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvshow)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbma.Location = new System.Drawing.Point(36, 16);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(49, 18);
            this.lbma.TabIndex = 0;
            this.lbma.Text = "MaNV";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(36, 54);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(53, 18);
            this.lbten.TabIndex = 1;
            this.lbten.Text = "TenNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Phòng";
            // 
            // dtgvshow
            // 
            this.dtgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvshow.Location = new System.Drawing.Point(51, 315);
            this.dtgvshow.Name = "dtgvshow";
            this.dtgvshow.Size = new System.Drawing.Size(626, 230);
            this.dtgvshow.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbphongban);
            this.panel1.Controls.Add(this.dtpktime);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.btsua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Controls.Add(this.tbtenphong);
            this.panel1.Controls.Add(this.tbngaysinh);
            this.panel1.Controls.Add(this.tbten);
            this.panel1.Controls.Add(this.tbmanv);
            this.panel1.Controls.Add(this.lbma);
            this.panel1.Controls.Add(this.lbten);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(51, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 272);
            this.panel1.TabIndex = 7;
            // 
            // tbmanv
            // 
            this.tbmanv.Location = new System.Drawing.Point(136, 16);
            this.tbmanv.Multiline = true;
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(154, 20);
            this.tbmanv.TabIndex = 6;
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(136, 54);
            this.tbten.Multiline = true;
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(154, 20);
            this.tbten.TabIndex = 7;
            // 
            // tbngaysinh
            // 
            this.tbngaysinh.Location = new System.Drawing.Point(136, 102);
            this.tbngaysinh.Multiline = true;
            this.tbngaysinh.Name = "tbngaysinh";
            this.tbngaysinh.Size = new System.Drawing.Size(154, 20);
            this.tbngaysinh.TabIndex = 8;
            // 
            // tbtenphong
            // 
            this.tbtenphong.Location = new System.Drawing.Point(136, 235);
            this.tbtenphong.Multiline = true;
            this.tbtenphong.Name = "tbtenphong";
            this.tbtenphong.Size = new System.Drawing.Size(154, 20);
            this.tbtenphong.TabIndex = 11;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(321, 10);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 12;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(321, 61);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 13;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(321, 109);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btchon);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(529, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 272);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btchon
            // 
            this.btchon.Location = new System.Drawing.Point(43, 213);
            this.btchon.Name = "btchon";
            this.btchon.Size = new System.Drawing.Size(75, 23);
            this.btchon.TabIndex = 1;
            this.btchon.Text = "Chọn ảnh";
            this.btchon.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // dtpktime
            // 
            this.dtpktime.Location = new System.Drawing.Point(136, 151);
            this.dtpktime.Name = "dtpktime";
            this.dtpktime.Size = new System.Drawing.Size(154, 20);
            this.dtpktime.TabIndex = 15;
            // 
            // cbbphongban
            // 
            this.cbbphongban.FormattingEnabled = true;
            this.cbbphongban.Location = new System.Drawing.Point(136, 193);
            this.cbbphongban.Name = "cbbphongban";
            this.cbbphongban.Size = new System.Drawing.Size(154, 21);
            this.cbbphongban.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvshow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvshow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvshow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbtenphong;
        private System.Windows.Forms.TextBox tbngaysinh;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btchon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpktime;
        private System.Windows.Forms.ComboBox cbbphongban;
    }
}

