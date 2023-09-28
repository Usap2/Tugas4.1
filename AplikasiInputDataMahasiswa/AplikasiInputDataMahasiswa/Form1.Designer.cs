namespace AplikasiInputDataMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btmSimpan = new System.Windows.Forms.Button();
            this.btmReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btmHapus = new System.Windows.Forms.Button();
            this.btmTampilkanData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(56, 12);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(95, 20);
            this.txtNIM.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(56, 38);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(155, 20);
            this.txtNama.TabIndex = 5;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(56, 64);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(95, 20);
            this.txtKelas.TabIndex = 6;
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(56, 90);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(95, 20);
            this.txtNilai.TabIndex = 7;
            this.txtNilai.TextChanged += new System.EventHandler(this.txtNilai_TextChanged);
            this.txtNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilai_KeyPress);
            // 
            // btmSimpan
            // 
            this.btmSimpan.Location = new System.Drawing.Point(18, 116);
            this.btmSimpan.Name = "btmSimpan";
            this.btmSimpan.Size = new System.Drawing.Size(75, 23);
            this.btmSimpan.TabIndex = 8;
            this.btmSimpan.Text = "Simpan";
            this.btmSimpan.UseVisualStyleBackColor = true;
            this.btmSimpan.Click += new System.EventHandler(this.btmSimpan_Click);
            // 
            // btmReset
            // 
            this.btmReset.Location = new System.Drawing.Point(99, 116);
            this.btmReset.Name = "btmReset";
            this.btmReset.Size = new System.Drawing.Size(75, 23);
            this.btmReset.TabIndex = 9;
            this.btmReset.Text = "Reset";
            this.btmReset.UseVisualStyleBackColor = true;
            this.btmReset.Click += new System.EventHandler(this.btmReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Controls.Add(this.btmHapus);
            this.groupBox1.Controls.Add(this.btmTampilkanData);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[DaftarMahasiswa]";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 48);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(559, 372);
            this.lvwMahasiswa.TabIndex = 12;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            // 
            // btmHapus
            // 
            this.btmHapus.Location = new System.Drawing.Point(115, 19);
            this.btmHapus.Name = "btmHapus";
            this.btmHapus.Size = new System.Drawing.Size(102, 23);
            this.btmHapus.TabIndex = 11;
            this.btmHapus.Text = "Hapus";
            this.btmHapus.UseVisualStyleBackColor = true;
            this.btmHapus.Click += new System.EventHandler(this.btmHapus_Click);
            // 
            // btmTampilkanData
            // 
            this.btmTampilkanData.Location = new System.Drawing.Point(6, 19);
            this.btmTampilkanData.Name = "btmTampilkanData";
            this.btmTampilkanData.Size = new System.Drawing.Size(103, 23);
            this.btmTampilkanData.TabIndex = 10;
            this.btmTampilkanData.Text = "Tampilkan Data";
            this.btmTampilkanData.UseVisualStyleBackColor = true;
            this.btmTampilkanData.Click += new System.EventHandler(this.btmTampilkanData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btmReset);
            this.Controls.Add(this.btmSimpan);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Input Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btmSimpan;
        private System.Windows.Forms.Button btmReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btmHapus;
        private System.Windows.Forms.Button btmTampilkanData;
    }
}

