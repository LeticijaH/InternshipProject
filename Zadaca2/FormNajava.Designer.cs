
namespace Zadaca2
{
    partial class FormNajava
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
            this.btnNajaviSe = new System.Windows.Forms.Button();
            this.labelKorImeN = new System.Windows.Forms.Label();
            this.labelLozinkaN = new System.Windows.Forms.Label();
            this.tbNickNameNajava = new System.Windows.Forms.TextBox();
            this.tbPasswordNajava = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNajaviSe
            // 
            this.btnNajaviSe.Location = new System.Drawing.Point(212, 253);
            this.btnNajaviSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnNajaviSe.Name = "btnNajaviSe";
            this.btnNajaviSe.Size = new System.Drawing.Size(164, 38);
            this.btnNajaviSe.TabIndex = 0;
            this.btnNajaviSe.Text = "Најавете се!";
            this.btnNajaviSe.UseVisualStyleBackColor = true;
            this.btnNajaviSe.Click += new System.EventHandler(this.btnNajaviSe_Click);
            // 
            // labelKorImeN
            // 
            this.labelKorImeN.AutoSize = true;
            this.labelKorImeN.Location = new System.Drawing.Point(68, 82);
            this.labelKorImeN.Name = "labelKorImeN";
            this.labelKorImeN.Size = new System.Drawing.Size(150, 20);
            this.labelKorImeN.TabIndex = 1;
            this.labelKorImeN.Text = "Корисничко име:";
            // 
            // labelLozinkaN
            // 
            this.labelLozinkaN.AutoSize = true;
            this.labelLozinkaN.Location = new System.Drawing.Point(68, 161);
            this.labelLozinkaN.Name = "labelLozinkaN";
            this.labelLozinkaN.Size = new System.Drawing.Size(84, 20);
            this.labelLozinkaN.TabIndex = 2;
            this.labelLozinkaN.Text = "Лозинка:";
            // 
            // tbNickNameNajava
            // 
            this.tbNickNameNajava.Location = new System.Drawing.Point(233, 79);
            this.tbNickNameNajava.Name = "tbNickNameNajava";
            this.tbNickNameNajava.Size = new System.Drawing.Size(239, 27);
            this.tbNickNameNajava.TabIndex = 3;
            // 
            // tbPasswordNajava
            // 
            this.tbPasswordNajava.Location = new System.Drawing.Point(233, 158);
            this.tbPasswordNajava.Name = "tbPasswordNajava";
            this.tbPasswordNajava.PasswordChar = '*';
            this.tbPasswordNajava.Size = new System.Drawing.Size(239, 27);
            this.tbPasswordNajava.TabIndex = 4;
            // 
            // FormNajava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 332);
            this.Controls.Add(this.tbPasswordNajava);
            this.Controls.Add(this.tbNickNameNajava);
            this.Controls.Add(this.labelLozinkaN);
            this.Controls.Add(this.labelKorImeN);
            this.Controls.Add(this.btnNajaviSe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNajava";
            this.Text = "Најава на оператор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNajava_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNajaviSe;
        private System.Windows.Forms.Label labelKorImeN;
        private System.Windows.Forms.Label labelLozinkaN;
        private System.Windows.Forms.TextBox tbNickNameNajava;
        private System.Windows.Forms.TextBox tbPasswordNajava;
    }
}