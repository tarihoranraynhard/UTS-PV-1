/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 05/05/2022
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cafe
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = cafe; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_barang";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"data_barang") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_barang";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void ResetData(){
			tbKode.Text="";
			tbNama.Text="";
			tbHarga.Text="";
		}
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReadData();
			ResetData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PembelianToolStripMenuItemClick(object sender, EventArgs e)
		{
			Pembelian tampil = new Pembelian();
			tampil.Show();
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
				if(tbKode.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbHarga.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{			
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "INSERT INTO  data_barang VALUES ('"+tbKode.Text+"','"+tbNama.Text+"','"+tbHarga.Text+"')";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_barang";
				}
				MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}				
		}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
				if(tbKode.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbHarga.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "UPDATE data_barang SET kode='"+tbKode.Text+"',nama='"+tbNama.Text+"',harga='"+tbHarga.Text+"' WHERE kode ='"+tbKode.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_barang";
				}
				MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Yakin ingin menghapus "+tbKode.Text+ "?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "DELETE FROM data_barang WHERE kode='"+tbKode.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_barang")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_barang";
				}
				MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
			}			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
				try{
					DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
					tbKode.Text = row.Cells["kode"].Value.ToString();
					tbNama.Text = row.Cells["nama"].Value.ToString();
					tbHarga.Text = row.Cells["harga"].Value.ToString();
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}		
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void DataBarangToolStripMenuItemClick(object sender, EventArgs e)
		{
			Pegawai tampil = new Pegawai();
			tampil.Show();
		}
	}
}
