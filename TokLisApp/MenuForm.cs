using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TokLisApp
{
    public partial class MenuForm : Form
    {
        private int status;
        private int custid;
        private string custname;
        private bool existToken;
        public MenuForm()
        {
            InitializeComponent();
        }
        private void TokenInsert_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(TokenInsert.Text) || TokenInsert.Text == ""))
            {
                Unused.Enabled = true;
                Used.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                Unused.Enabled = false;
                Unused.Checked = false;
                Used.Enabled = false;
                Used.Checked = false;
                Delete.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
        private void CopyPasteButton_Click(object sender, System.EventArgs e)
        {
            if (this.dataGridView1
                .GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        this.dataGridView1.GetClipboardContent());

                    // Replace the text box contents with the clipboard text.
                    this.TokenInsert.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    this.TokenInsert.Text = "The Clipboard could not be accessed. Please try again.";
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "TERPAKAI")
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                }
                else if (row.Cells[5].Value.ToString() == "BELUM TERPAKAI")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

        }

        private void AppLabel_Click(object sender, EventArgs e)
        {
        }
        private void ReadCust()
        {
            Database db = new Database();
            string query = "SELECT * FROM cust WHERE cust_id = (SELECT max(cust_id) FROM cust);";
            SQLiteCommand command = new SQLiteCommand(query, db.conn);
            db.openConn();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                custid = reader.GetInt32(0);
            };
            reader.Close();
            db.closeConn();
        }
        private void Unused_CheckedChanged(object sender, EventArgs e)
        {
            status = 0;
            if (!(Unused.Checked))
            {
                Insert.Enabled = false;
                Update.Enabled = false;
            } 
            else
            {
                Insert.Enabled = true;
                Update.Enabled = true;
            }
        }

        private void Used_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
            if (!(Used.Checked))
            {
                Insert.Enabled = false;
                Update.Enabled = false;
            }
            else
            {
                Insert.Enabled = true;
                Update.Enabled = true;
            }
        }

        private async void Insert_Click(object sender, EventArgs e)
        {
            ReadCust();
            existToken = false;
            MessageShow.Visible = false;
            Database db = new Database();
            string check = $"SELECT token_no FROM token WHERE token_no = '{TokenInsert.Text}';";
            SQLiteCommand cmdCheck = new SQLiteCommand(check, db.conn);
            db.openConn();
            SQLiteDataReader checkReader = cmdCheck.ExecuteReader();
            while (checkReader.Read())
            {
                if (checkReader.GetString(0) == TokenInsert.Text)
                {
                    existToken = true;
                }
                else
                {
                    existToken = false;
                }
            }
            if (existToken == true)
            {
                MessageShow.Visible = true;
                MessageShow.Text = "Data sudah ada";
                await Task.Delay(3000);
                MessageShow.Visible = false;
            }
            else
            {
                if (string.IsNullOrEmpty(TokenInsert.Text) || TokenInsert.Text == "")
                {
                    MessageShow.Visible = true;
                    MessageShow.Text = "Data tidak boleh kosong!";
                    await Task.Delay(3000);
                    MessageShow.Visible = false;
                }
                else
                {
                    string insert = $"INSERT INTO token (token_no, token_val, token_cust_id, token_status_type) VALUES ('{TokenInsert.Text}', '{ValueInsert.Text}', {custid}, {status});";
                    SQLiteCommand cmdInsert = new SQLiteCommand(insert, db.conn);
                    cmdInsert.ExecuteNonQuery();
                    MessageShow.Visible = true;
                    MessageShow.Text = "Data telah ditambahkan";
                    await Task.Delay(3000);
                    MessageShow.Visible = false;
                }
                db.closeConn();
            }
            
        }
        private async void Update_Click(object sender, EventArgs e)
        {
            MessageShow.Visible = false;
            Database db = new Database();
            string query = $"UPDATE token SET token_status_type = {status} WHERE token_no = '{TokenInsert.Text}';";
            SQLiteCommand command = new SQLiteCommand(query, db.conn);
            db.openConn();
            if (string.IsNullOrEmpty(TokenInsert.Text) || TokenInsert.Text == "")
            {
                MessageShow.Visible = true;
                MessageShow.Text = "Masukkan token!";
                await Task.Delay(3000);
                MessageShow.Visible = false;
            }
            else
            {
                command.ExecuteNonQuery();
                MessageShow.Visible = true;
                MessageShow.Text = "Data telah diperbarui";
                await Task.Delay(3000);
                MessageShow.Visible = false;
            }
            db.closeConn();
        }

        private async void ViewAll_Click(object sender, EventArgs e)
        {
            MessageShow.Visible = false;
            Database db = new Database();
            string query = "SELECT token_id as No, token_no as \"Nomor Token\", token_val as \"Value/Harga\", cust_name as \"Nama Pelanggan\",  cust_no as \"ID. Pelanggan\", status_desc as \"Status\" FROM token INNER JOIN cust ON cust_id = token_cust_id INNER JOIN status ON status_type = token_status_type;";
            SQLiteCommand command = new SQLiteCommand(query, db.conn);
            db.openConn();
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            DataGridViewColumn no = dataGridView1.Columns[0];
            DataGridViewColumn nomor_token = dataGridView1.Columns[1];
            DataGridViewColumn value = dataGridView1.Columns[2];
            DataGridViewColumn nama_pelanggan = dataGridView1.Columns[3];
            DataGridViewColumn id_pelanggan = dataGridView1.Columns[4];
            DataGridViewColumn status_desc = dataGridView1.Columns[5];
            no.Width = 35;
            nomor_token.Width = 235;
            value.Width = 125;
            nama_pelanggan.Width = 175;
            id_pelanggan.Width = 150;
            status_desc.Width = 150;            
            MessageShow.Visible = true;
            MessageShow.Text = "Data sudah ditampilkan";           
            db.closeConn();
            await Task.Delay(3000);
            MessageShow.Visible = false;
        }
        
        
        private void MenuForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }

        private void MessageShow_Click(object sender, EventArgs e)
        {

        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            MessageShow.Visible = false;
            Database db = new Database();
            string query = $"DELETE FROM token WHERE token_no = '{TokenInsert.Text}';";
            SQLiteCommand cmdDelete = new SQLiteCommand(query, db.conn);
            string check = $"SELECT token_no FROM token WHERE token_no = '{TokenInsert.Text}';";
            SQLiteCommand cmdCheck = new SQLiteCommand(check, db.conn);
            db.openConn();
            SQLiteDataReader checkReader = cmdCheck.ExecuteReader();
            db.openConn();
            while (checkReader.Read())
            {
                if (checkReader.GetString(0) == TokenInsert.Text)
                {
                    existToken = true;
                }
                else
                {
                    existToken = false;
                }
            }
            if (string.IsNullOrEmpty(TokenInsert.Text) || TokenInsert.Text == "")
            {
                MessageShow.Visible = true;
                MessageShow.Text = "Masukkan data yang ingin dihapus!";
                await Task.Delay(3000);
                MessageShow.Visible = false;
            }
            else
            {
                if (existToken != true)
                {
                    MessageShow.Visible = true;
                    MessageShow.Text = "Data tidak ditemukan";
                    await Task.Delay(3000);
                    MessageShow.Visible = false;
                }
                else
                {
                    cmdDelete.ExecuteNonQuery();
                    MessageShow.Visible = true;
                    MessageShow.Text = "Data telah dihapus";
                    await Task.Delay(3000);
                    MessageShow.Visible = false;
                }
            }
            db.closeConn();
        }
        private void custName_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
