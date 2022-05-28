/*
 * Created by SharpDevelop.
 * User: User
 * Date: 03/12/2021
 * Time: 22:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace tugasbesar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = programpv; Uid= root");
		//MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		PictureBox PictureBox1 = new PictureBox();
		Bitmap img;
		string pathimg;
		
		public void ReadData(){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from karyawan";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (MySqlException ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData(string SourceFilePath){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "insert into karyawan values('"+id.Text+"','"+nama_depan.Text+"','"+nama_belakang.Text+"','"+alamat.Text+"','"+telp.Text+"','"+posisi.Text+"',?Picture)";
				myadapter.SelectCommand = mycommand;
				System.IO.FileStream fs = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[] b = new Byte[fs.Length];
				fs.Read(b, 0, b.Length);
				fs.Close();
				MySqlParameter P = new MySqlParameter("?Picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, b);
				mycommand.Parameters.Add(P);
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
				co.Close();
			}
			catch(MySqlException ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void UpdateData(string SourceFilePath){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "update karyawan set id = '"+id.Text+"',nama_depan = '"+nama_depan.Text+"',nama_belakang = '"+nama_belakang.Text+"',alamat = '"+alamat.Text+"',telepon = '"+telp.Text+"',posisi = '"+posisi.Text+"',pic =?Picture where id = '"+id.Text+"'";
				myadapter.SelectCommand = mycommand;
				System.IO.FileStream fs = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[] b = new Byte[fs.Length];
				fs.Read(b, 0, b.Length);
				fs.Close();
				MySqlParameter P = new MySqlParameter("?Picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, b);
				mycommand.Parameters.Add(P);
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
				co.Close();
			}
			catch(MySqlException ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void DeleteData(){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="delete from karyawan where id='"+id.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
				co.Close();
			}
			catch(MySqlException ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void ResetData(){
			id.Text="";
			nama_depan.Text="";
			nama_belakang.Text="";
			alamat.Text="";
			telp.Text="";
			posisi.Text="";
			cari.Text="";
		}

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			InsertData(pathimg);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			UpdateData(pathimg);		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DeleteData();		
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama_depan.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			nama_belakang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();	
			telp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();	
			posisi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();	

try
			{
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(new MySqlCommand("SELECT pic from karyawan WHERE id = "+id.Text, co));
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				if(dataSet.Tables[0].Rows.Count == 1)
				{
					Byte[] data = new Byte[0];
					data = (Byte[])(dataSet.Tables[0].Rows[0]["pic"]);
					MemoryStream mem = new MemoryStream(data);
					pictureBox1.Image = Image.FromStream(mem);
				}
					co.Close();
			}
				catch(MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			ResetData();			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Application.Exit();		
		}
		
	
		public void finddata(){
			try{
				MySqlCommand mycommand = new MySqlCommand();
				co.Open();
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from karyawan where id like '%"+cari.Text+"%' or nama_depan like '%"+cari.Text+"%'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (MySqlException ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		void CariTextChanged(object sender, EventArgs e)
		{
			finddata();
		}
		
		
		

		
		
		
		
		
		
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
				posisi.Items.Add("Web Developer");
				posisi.Items.Add("Cyber Security");
				posisi.Items.Add("Data Scientist");
				posisi.Items.Add("UI UX Designer");
		}
		
		void GambarClick(object sender, EventArgs e)
		{
			if(DialogResult.OK ==openFileDialog1.ShowDialog())
			{
				img = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image=img;
				pathimg=openFileDialog1.FileName.ToString();
			}			
		}
	}
}
