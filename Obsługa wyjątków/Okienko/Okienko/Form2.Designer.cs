namespace Okienko
{
    partial class Form2
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
            this.Saldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Infotext = new System.Windows.Forms.TextBox();
            this.wplata = new System.Windows.Forms.Button();
            this.wyplata = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.PinZmien = new System.Windows.Forms.Button();
            this.wplatatext = new System.Windows.Forms.TextBox();
            this.wyplatatext = new System.Windows.Forms.TextBox();
            this.zmienPINtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Saldo
            // 
            this.Saldo.Location = new System.Drawing.Point(12, 26);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(257, 20);
            this.Saldo.TabIndex = 0;
            this.Saldo.TextChanged += new System.EventHandler(this.Saldo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Info o koncie";
            // 
            // Infotext
            // 
            this.Infotext.Location = new System.Drawing.Point(13, 74);
            this.Infotext.Multiline = true;
            this.Infotext.Name = "Infotext";
            this.Infotext.Size = new System.Drawing.Size(255, 67);
            this.Infotext.TabIndex = 3;
            // 
            // wplata
            // 
            this.wplata.Location = new System.Drawing.Point(12, 159);
            this.wplata.Name = "wplata";
            this.wplata.Size = new System.Drawing.Size(75, 23);
            this.wplata.TabIndex = 4;
            this.wplata.Text = "Wpłata";
            this.wplata.UseVisualStyleBackColor = true;
            this.wplata.Click += new System.EventHandler(this.wplata_Click);
            // 
            // wyplata
            // 
            this.wyplata.Location = new System.Drawing.Point(12, 188);
            this.wyplata.Name = "wyplata";
            this.wyplata.Size = new System.Drawing.Size(75, 23);
            this.wyplata.TabIndex = 5;
            this.wyplata.Text = "Wypłata";
            this.wyplata.UseVisualStyleBackColor = true;
            this.wyplata.Click += new System.EventHandler(this.wyplata_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(12, 217);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(75, 23);
            this.Info.TabIndex = 6;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // PinZmien
            // 
            this.PinZmien.Location = new System.Drawing.Point(12, 246);
            this.PinZmien.Name = "PinZmien";
            this.PinZmien.Size = new System.Drawing.Size(75, 23);
            this.PinZmien.TabIndex = 7;
            this.PinZmien.Text = "Zmień PIN";
            this.PinZmien.UseVisualStyleBackColor = true;
            this.PinZmien.Click += new System.EventHandler(this.PinZmien_Click);
            // 
            // wplatatext
            // 
            this.wplatatext.Location = new System.Drawing.Point(104, 159);
            this.wplatatext.Name = "wplatatext";
            this.wplatatext.Size = new System.Drawing.Size(164, 20);
            this.wplatatext.TabIndex = 8;
            // 
            // wyplatatext
            // 
            this.wyplatatext.Location = new System.Drawing.Point(104, 185);
            this.wyplatatext.Name = "wyplatatext";
            this.wyplatatext.Size = new System.Drawing.Size(164, 20);
            this.wyplatatext.TabIndex = 9;
            this.wyplatatext.TextChanged += new System.EventHandler(this.wyplatatext_TextChanged);
            // 
            // zmienPINtext
            // 
            this.zmienPINtext.Location = new System.Drawing.Point(104, 246);
            this.zmienPINtext.Name = "zmienPINtext";
            this.zmienPINtext.Size = new System.Drawing.Size(165, 20);
            this.zmienPINtext.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 279);
            this.Controls.Add(this.zmienPINtext);
            this.Controls.Add(this.wyplatatext);
            this.Controls.Add(this.wplatatext);
            this.Controls.Add(this.PinZmien);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.wyplata);
            this.Controls.Add(this.wplata);
            this.Controls.Add(this.Infotext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Saldo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Saldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Infotext;
        private System.Windows.Forms.Button wplata;
        private System.Windows.Forms.Button wyplata;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button PinZmien;
        private System.Windows.Forms.TextBox wplatatext;
        private System.Windows.Forms.TextBox wyplatatext;
        private System.Windows.Forms.TextBox zmienPINtext;
    }
}