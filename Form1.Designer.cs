namespace NKatmanliMimari
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.lblmaas = new System.Windows.Forms.Label();
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.lblsehir = new System.Windows.Forms.Label();
            this.txtgorev = new System.Windows.Forms.TextBox();
            this.lblgorev = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(43, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(34, 23);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(78, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(203, 31);
            this.txtid.TabIndex = 2;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(575, 5);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(114, 29);
            this.btnlistele.TabIndex = 3;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(78, 51);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(203, 31);
            this.txtad.TabIndex = 5;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(36, 54);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(41, 23);
            this.lblad.TabIndex = 4;
            this.lblad.Text = "AD:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(78, 96);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(203, 31);
            this.txtsoyad.TabIndex = 7;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(0, 99);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(77, 23);
            this.lblsoyad.TabIndex = 6;
            this.lblsoyad.Text = "SOYAD:";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(366, 6);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(203, 31);
            this.txtmaas.TabIndex = 9;
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Location = new System.Drawing.Point(293, 9);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(67, 23);
            this.lblmaas.TabIndex = 8;
            this.lblmaas.Text = "MAAŞ:";
            // 
            // txtsehir
            // 
            this.txtsehir.Location = new System.Drawing.Point(366, 51);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(203, 31);
            this.txtsehir.TabIndex = 11;
            // 
            // lblsehir
            // 
            this.lblsehir.AutoSize = true;
            this.lblsehir.Location = new System.Drawing.Point(292, 54);
            this.lblsehir.Name = "lblsehir";
            this.lblsehir.Size = new System.Drawing.Size(68, 23);
            this.lblsehir.TabIndex = 10;
            this.lblsehir.Text = "ŞEHİR:";
            // 
            // txtgorev
            // 
            this.txtgorev.Location = new System.Drawing.Point(366, 96);
            this.txtgorev.Name = "txtgorev";
            this.txtgorev.Size = new System.Drawing.Size(203, 31);
            this.txtgorev.TabIndex = 13;
            // 
            // lblgorev
            // 
            this.lblgorev.AutoSize = true;
            this.lblgorev.Location = new System.Drawing.Point(283, 99);
            this.lblgorev.Name = "lblgorev";
            this.lblgorev.Size = new System.Drawing.Size(77, 23);
            this.lblgorev.TabIndex = 12;
            this.lblgorev.Text = "GÖREV:";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(575, 36);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(114, 29);
            this.btnekle.TabIndex = 14;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(575, 98);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(114, 29);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(575, 67);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(114, 29);
            this.btnguncelle.TabIndex = 15;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 441);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtgorev);
            this.Controls.Add(this.lblgorev);
            this.Controls.Add(this.txtsehir);
            this.Controls.Add(this.lblsehir);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label lblmaas;
        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.Label lblsehir;
        private System.Windows.Forms.TextBox txtgorev;
        private System.Windows.Forms.Label lblgorev;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}

