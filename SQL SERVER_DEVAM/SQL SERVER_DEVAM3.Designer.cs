namespace SQL_SERVER_DEVAM
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Btn_listele = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Btn_kaydet = new System.Windows.Forms.Button();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 251);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1200, 373);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Btn_listele
            // 
            this.Btn_listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_listele.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_listele.Location = new System.Drawing.Point(1086, 12);
            this.Btn_listele.Name = "Btn_listele";
            this.Btn_listele.Size = new System.Drawing.Size(102, 41);
            this.Btn_listele.TabIndex = 1;
            this.Btn_listele.Text = "Listele";
            this.Btn_listele.UseVisualStyleBackColor = false;
            this.Btn_listele.Click += new System.EventHandler(this.Btn_listele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "KİTAP ADI:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(124, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 32);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "YAZAR:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(124, 109);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 32);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "YAYINEVİ:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(124, 153);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 32);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "SAYFA NO:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(124, 197);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 32);
            this.textBox5.TabIndex = 10;
            // 
            // Btn_kaydet
            // 
            this.Btn_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_kaydet.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_kaydet.Location = new System.Drawing.Point(1086, 60);
            this.Btn_kaydet.Name = "Btn_kaydet";
            this.Btn_kaydet.Size = new System.Drawing.Size(102, 41);
            this.Btn_kaydet.TabIndex = 12;
            this.Btn_kaydet.Text = "Kaydet";
            this.Btn_kaydet.UseVisualStyleBackColor = false;
            this.Btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sil.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sil.Location = new System.Drawing.Point(1086, 107);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(102, 41);
            this.Btn_sil.TabIndex = 13;
            this.Btn_sil.Text = "Sil";
            this.Btn_sil.UseVisualStyleBackColor = false;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guncelle.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guncelle.Location = new System.Drawing.Point(1086, 155);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(102, 41);
            this.Btn_guncelle.TabIndex = 14;
            this.Btn_guncelle.Text = "Güncelle";
            this.Btn_guncelle.UseVisualStyleBackColor = false;
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1086, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "ARANACAK ID:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(606, 21);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 32);
            this.textBox6.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.Btn_sil);
            this.Controls.Add(this.Btn_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_listele);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SQL Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Btn_listele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Btn_kaydet;
        private System.Windows.Forms.Button Btn_sil;
        private System.Windows.Forms.Button Btn_guncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}

