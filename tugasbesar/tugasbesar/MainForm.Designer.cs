/*
 * Created by SharpDevelop.
 * User: User
 * Date: 03/12/2021
 * Time: 22:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugasbesar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cari = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.gambar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.posisi = new System.Windows.Forms.ComboBox();
			this.id = new System.Windows.Forms.TextBox();
			this.nama_depan = new System.Windows.Forms.TextBox();
			this.nama_belakang = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.telp = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.IDKaryawan = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(16, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1060, 130);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(21, 17);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1033, 97);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
			this.label1.Location = new System.Drawing.Point(364, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(427, 57);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data Karyawan";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(16, 153);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1060, 754);
			this.panel3.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
			this.panel6.Controls.Add(this.label2);
			this.panel6.Controls.Add(this.cari);
			this.panel6.Location = new System.Drawing.Point(800, 17);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(236, 96);
			this.panel6.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 39);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cari Karyawan";
			// 
			// cari
			// 
			this.cari.Location = new System.Drawing.Point(29, 52);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(184, 22);
			this.cari.TabIndex = 0;
			this.cari.TextChanged += new System.EventHandler(this.CariTextChanged);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
			this.panel5.Controls.Add(this.button6);
			this.panel5.Controls.Add(this.button4);
			this.panel5.Controls.Add(this.button3);
			this.panel5.Controls.Add(this.button2);
			this.panel5.Controls.Add(this.button1);
			this.panel5.Location = new System.Drawing.Point(800, 123);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(236, 618);
			this.panel5.TabIndex = 1;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(196)))));
			this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(17, 510);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(196, 92);
			this.button6.TabIndex = 5;
			this.button6.Text = "Exit";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(196)))));
			this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(17, 383);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(196, 96);
			this.button4.TabIndex = 3;
			this.button4.Text = "Reset";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(196)))));
			this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(17, 258);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(196, 94);
			this.button3.TabIndex = 2;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(196)))));
			this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(17, 133);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(196, 96);
			this.button2.TabIndex = 1;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(196)))));
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(17, 16);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(196, 92);
			this.button1.TabIndex = 0;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
			this.panel4.Controls.Add(this.gambar);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Controls.Add(this.posisi);
			this.panel4.Controls.Add(this.id);
			this.panel4.Controls.Add(this.nama_depan);
			this.panel4.Controls.Add(this.nama_belakang);
			this.panel4.Controls.Add(this.alamat);
			this.panel4.Controls.Add(this.telp);
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.IDKaryawan);
			this.panel4.Location = new System.Drawing.Point(21, 17);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(771, 724);
			this.panel4.TabIndex = 0;
			// 
			// gambar
			// 
			this.gambar.Location = new System.Drawing.Point(561, 406);
			this.gambar.Name = "gambar";
			this.gambar.Size = new System.Drawing.Size(117, 31);
			this.gambar.TabIndex = 20;
			this.gambar.Text = "Upload Foto";
			this.gambar.UseVisualStyleBackColor = true;
			this.gambar.Click += new System.EventHandler(this.GambarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(552, 257);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(135, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// posisi
			// 
			this.posisi.FormattingEnabled = true;
			this.posisi.Location = new System.Drawing.Point(249, 339);
			this.posisi.Name = "posisi";
			this.posisi.Size = new System.Drawing.Size(205, 24);
			this.posisi.TabIndex = 18;
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(249, 16);
			this.id.Margin = new System.Windows.Forms.Padding(4);
			this.id.Multiline = true;
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(496, 34);
			this.id.TabIndex = 17;
			// 
			// nama_depan
			// 
			this.nama_depan.Location = new System.Drawing.Point(249, 71);
			this.nama_depan.Margin = new System.Windows.Forms.Padding(4);
			this.nama_depan.Multiline = true;
			this.nama_depan.Name = "nama_depan";
			this.nama_depan.Size = new System.Drawing.Size(496, 34);
			this.nama_depan.TabIndex = 16;
			// 
			// nama_belakang
			// 
			this.nama_belakang.Location = new System.Drawing.Point(249, 139);
			this.nama_belakang.Margin = new System.Windows.Forms.Padding(4);
			this.nama_belakang.Multiline = true;
			this.nama_belakang.Name = "nama_belakang";
			this.nama_belakang.Size = new System.Drawing.Size(496, 34);
			this.nama_belakang.TabIndex = 15;
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(249, 203);
			this.alamat.Margin = new System.Windows.Forms.Padding(4);
			this.alamat.Multiline = true;
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(496, 34);
			this.alamat.TabIndex = 14;
			// 
			// telp
			// 
			this.telp.Location = new System.Drawing.Point(249, 270);
			this.telp.Margin = new System.Windows.Forms.Padding(4);
			this.telp.Multiline = true;
			this.telp.Name = "telp";
			this.telp.Size = new System.Drawing.Size(205, 34);
			this.telp.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(17, 481);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(729, 227);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 336);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(173, 34);
			this.label7.TabIndex = 10;
			this.label7.Text = "Posisi";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(17, 267);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 28);
			this.label6.TabIndex = 8;
			this.label6.Text = "Nomor Telepon";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 203);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 34);
			this.label5.TabIndex = 6;
			this.label5.Text = "Alamat";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 139);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 34);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nama Belakang";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 71);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nama Depan";
			// 
			// IDKaryawan
			// 
			this.IDKaryawan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IDKaryawan.Location = new System.Drawing.Point(17, 16);
			this.IDKaryawan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.IDKaryawan.Name = "IDKaryawan";
			this.IDKaryawan.Size = new System.Drawing.Size(173, 34);
			this.IDKaryawan.TabIndex = 0;
			this.IDKaryawan.Text = "ID Karyawan";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 922);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "tugasbesar";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button gambar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox posisi;
		private System.Windows.Forms.TextBox cari;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label IDKaryawan;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nama_belakang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nama_depan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox telp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
