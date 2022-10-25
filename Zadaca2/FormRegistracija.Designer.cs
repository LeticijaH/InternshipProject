
namespace Zadaca2
{
    partial class FormRegistracija
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
            this.tbImeKorisnik = new System.Windows.Forms.TextBox();
            this.labelImeKorisnik = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.tbNickNameR = new System.Windows.Forms.TextBox();
            this.labelNickName = new System.Windows.Forms.Label();
            this.tbPasswordR = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.btRegistrirajSe = new System.Windows.Forms.Button();
            this.errorProviderLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLozinka)).BeginInit();
            this.SuspendLayout();
            // 
            // tbImeKorisnik
            // 
            this.tbImeKorisnik.Location = new System.Drawing.Point(246, 72);
            this.tbImeKorisnik.Name = "tbImeKorisnik";
            this.tbImeKorisnik.Size = new System.Drawing.Size(205, 27);
            this.tbImeKorisnik.TabIndex = 3;
            // 
            // labelImeKorisnik
            // 
            this.labelImeKorisnik.AutoSize = true;
            this.labelImeKorisnik.Location = new System.Drawing.Point(80, 75);
            this.labelImeKorisnik.Name = "labelImeKorisnik";
            this.labelImeKorisnik.Size = new System.Drawing.Size(47, 20);
            this.labelImeKorisnik.TabIndex = 2;
            this.labelImeKorisnik.Text = "Име:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(246, 134);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(205, 27);
            this.tbPrezime.TabIndex = 5;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(80, 137);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(88, 20);
            this.labelPrezime.TabIndex = 4;
            this.labelPrezime.Text = "Презиме:";
            // 
            // tbNickNameR
            // 
            this.tbNickNameR.Location = new System.Drawing.Point(246, 194);
            this.tbNickNameR.Name = "tbNickNameR";
            this.tbNickNameR.Size = new System.Drawing.Size(205, 27);
            this.tbNickNameR.TabIndex = 7;
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.Location = new System.Drawing.Point(80, 197);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(150, 20);
            this.labelNickName.TabIndex = 6;
            this.labelNickName.Text = "Корисничко име:";
            // 
            // tbPasswordR
            // 
            this.tbPasswordR.Location = new System.Drawing.Point(246, 259);
            this.tbPasswordR.Name = "tbPasswordR";
            this.tbPasswordR.PasswordChar = '*';
            this.tbPasswordR.Size = new System.Drawing.Size(205, 27);
            this.tbPasswordR.TabIndex = 9;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(80, 262);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(84, 20);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Лозинка:";
            // 
            // btRegistrirajSe
            // 
            this.btRegistrirajSe.Location = new System.Drawing.Point(157, 360);
            this.btRegistrirajSe.Name = "btRegistrirajSe";
            this.btRegistrirajSe.Size = new System.Drawing.Size(193, 34);
            this.btRegistrirajSe.TabIndex = 10;
            this.btRegistrirajSe.Text = "Регистрирај се!";
            this.btRegistrirajSe.UseVisualStyleBackColor = true;
            this.btRegistrirajSe.Click += new System.EventHandler(this.btRegistrirajSe_Click);
            // 
            // errorProviderLozinka
            // 
            this.errorProviderLozinka.ContainerControl = this;
            // 
            // FormRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 425);
            this.Controls.Add(this.btRegistrirajSe);
            this.Controls.Add(this.tbPasswordR);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.tbNickNameR);
            this.Controls.Add(this.labelNickName);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.tbImeKorisnik);
            this.Controls.Add(this.labelImeKorisnik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistracija";
            this.Text = "Регистрација на нов оператор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistracija_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLozinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbImeKorisnik;
        private System.Windows.Forms.Label labelImeKorisnik;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox tbNickNameR;
        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.TextBox tbPasswordR;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button btRegistrirajSe;
        private System.Windows.Forms.ErrorProvider errorProviderLozinka;
    }
}