namespace TokLisApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Used = new System.Windows.Forms.RadioButton();
            this.Unused = new System.Windows.Forms.RadioButton();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.TokenInsert = new System.Windows.Forms.TextBox();
            this.ViewAll = new System.Windows.Forms.Button();
            this.AppLabel = new System.Windows.Forms.Label();
            this.MessageShow = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.labelTokenInsert = new System.Windows.Forms.Label();
            this.ValueInsert = new System.Windows.Forms.TextBox();
            this.labelValueInsert = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(927, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Used
            // 
            this.Used.AutoSize = true;
            this.Used.Enabled = false;
            this.Used.Location = new System.Drawing.Point(20, 266);
            this.Used.Name = "Used";
            this.Used.Size = new System.Drawing.Size(102, 23);
            this.Used.TabIndex = 1;
            this.Used.TabStop = true;
            this.Used.Text = "Terpakai";
            this.Used.UseVisualStyleBackColor = true;
            this.Used.CheckedChanged += new System.EventHandler(this.Used_CheckedChanged);
            // 
            // Unused
            // 
            this.Unused.AutoSize = true;
            this.Unused.Enabled = false;
            this.Unused.Location = new System.Drawing.Point(20, 237);
            this.Unused.Name = "Unused";
            this.Unused.Size = new System.Drawing.Size(156, 23);
            this.Unused.TabIndex = 2;
            this.Unused.TabStop = true;
            this.Unused.Text = "Belum Terpakai";
            this.Unused.UseVisualStyleBackColor = true;
            this.Unused.CheckedChanged += new System.EventHandler(this.Unused_CheckedChanged);
            // 
            // Update
            // 
            this.Update.Enabled = false;
            this.Update.Location = new System.Drawing.Point(128, 306);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 28);
            this.Update.TabIndex = 3;
            this.Update.Text = "Perbarui";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Enabled = false;
            this.Insert.Location = new System.Drawing.Point(20, 306);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(102, 28);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Simpan";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // TokenInsert
            // 
            this.TokenInsert.Location = new System.Drawing.Point(20, 133);
            this.TokenInsert.Name = "TokenInsert";
            this.TokenInsert.Size = new System.Drawing.Size(225, 26);
            this.TokenInsert.TabIndex = 5;
            this.TokenInsert.TextChanged += new System.EventHandler(this.TokenInsert_TextChanged);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(20, 375);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(119, 29);
            this.ViewAll.TabIndex = 6;
            this.ViewAll.Text = "Lihat Semua";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("JetBrains Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppLabel.Location = new System.Drawing.Point(5, 8);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(278, 82);
            this.AppLabel.TabIndex = 7;
            this.AppLabel.Text = "Manajemen \r\nToken Listrik";
            this.AppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppLabel.Click += new System.EventHandler(this.AppLabel_Click);
            // 
            // MessageShow
            // 
            this.MessageShow.AutoSize = true;
            this.MessageShow.Location = new System.Drawing.Point(20, 416);
            this.MessageShow.Name = "MessageShow";
            this.MessageShow.Size = new System.Drawing.Size(108, 19);
            this.MessageShow.TabIndex = 8;
            this.MessageShow.Text = "MessageShow";
            this.MessageShow.Visible = false;
            this.MessageShow.Click += new System.EventHandler(this.MessageShow_Click);
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Location = new System.Drawing.Point(20, 445);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(153, 57);
            this.custName.TabIndex = 9;
            this.custName.Text = "Dibuat oleh\r\nKelompok ...\r\nVer 2.0";
            this.custName.Click += new System.EventHandler(this.custName_Click);
            // 
            // labelTokenInsert
            // 
            this.labelTokenInsert.AutoSize = true;
            this.labelTokenInsert.Location = new System.Drawing.Point(20, 111);
            this.labelTokenInsert.Name = "labelTokenInsert";
            this.labelTokenInsert.Size = new System.Drawing.Size(153, 19);
            this.labelTokenInsert.TabIndex = 11;
            this.labelTokenInsert.Text = "No. STROOM/TOKEN";
            // 
            // ValueInsert
            // 
            this.ValueInsert.Location = new System.Drawing.Point(20, 195);
            this.ValueInsert.Name = "ValueInsert";
            this.ValueInsert.Size = new System.Drawing.Size(115, 26);
            this.ValueInsert.TabIndex = 12;
            // 
            // labelValueInsert
            // 
            this.labelValueInsert.AutoSize = true;
            this.labelValueInsert.Location = new System.Drawing.Point(20, 173);
            this.labelValueInsert.Name = "labelValueInsert";
            this.labelValueInsert.Size = new System.Drawing.Size(54, 19);
            this.labelValueInsert.TabIndex = 13;
            this.labelValueInsert.Text = "Value";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(20, 340);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(102, 29);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Hapus";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 519);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.labelValueInsert);
            this.Controls.Add(this.ValueInsert);
            this.Controls.Add(this.labelTokenInsert);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.MessageShow);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.TokenInsert);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Unused);
            this.Controls.Add(this.Used);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton Used;
        private RadioButton Unused;
        private Button Update;
        private Button Insert;
        private TextBox TokenInsert;
        private Button ViewAll;
        private Label AppLabel;
        private Label MessageShow;
        private Label custName;
        private Label labelTokenInsert;
        private TextBox ValueInsert;
        private Label labelValueInsert;
        private Button Delete;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
    }
}