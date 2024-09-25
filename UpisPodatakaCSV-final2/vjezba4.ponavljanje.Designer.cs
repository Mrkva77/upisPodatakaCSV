namespace upisivanjePodatakaCSV
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtgodina = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupis = new System.Windows.Forms.Button();
            this.btnspremi = new System.Windows.Forms.Button();
            this.btnbrisanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(159, 170);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(276, 26);
            this.txtemail.TabIndex = 4;
            // 
            // txtgodina
            // 
            this.txtgodina.Location = new System.Drawing.Point(159, 138);
            this.txtgodina.Name = "txtgodina";
            this.txtgodina.Size = new System.Drawing.Size(276, 26);
            this.txtgodina.TabIndex = 3;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(159, 74);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(271, 26);
            this.txtime.TabIndex = 1;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(159, 106);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(271, 26);
            this.txtprezime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Godina rođenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ime";
            // 
            // btnupis
            // 
            this.btnupis.Location = new System.Drawing.Point(39, 233);
            this.btnupis.Name = "btnupis";
            this.btnupis.Size = new System.Drawing.Size(114, 59);
            this.btnupis.TabIndex = 5;
            this.btnupis.Text = "Upis";
            this.btnupis.UseVisualStyleBackColor = true;
            this.btnupis.Click += new System.EventHandler(this.btnupis_Click);
            // 
            // btnspremi
            // 
            this.btnspremi.Location = new System.Drawing.Point(316, 233);
            this.btnspremi.Name = "btnspremi";
            this.btnspremi.Size = new System.Drawing.Size(114, 59);
            this.btnspremi.TabIndex = 7;
            this.btnspremi.Text = "Spremi";
            this.btnspremi.UseVisualStyleBackColor = true;
            this.btnspremi.Click += new System.EventHandler(this.btnspremi_Click);
            // 
            // btnbrisanje
            // 
            this.btnbrisanje.Location = new System.Drawing.Point(177, 233);
            this.btnbrisanje.Name = "btnbrisanje";
            this.btnbrisanje.Size = new System.Drawing.Size(114, 59);
            this.btnbrisanje.TabIndex = 6;
            this.btnbrisanje.Text = "Brisanje";
            this.btnbrisanje.UseVisualStyleBackColor = true;
            this.btnbrisanje.Click += new System.EventHandler(this.btnbrisanje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 317);
            this.Controls.Add(this.btnbrisanje);
            this.Controls.Add(this.btnspremi);
            this.Controls.Add(this.btnupis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.txtgodina);
            this.Controls.Add(this.txtemail);
            this.Name = "Form1";
            this.Text = "upisivanjePodatakaCSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtgodina;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupis;
        private System.Windows.Forms.Button btnspremi;
        private System.Windows.Forms.Button btnbrisanje;
    }
}

