
namespace Zadaca2
{
    partial class FormStart
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
            this.labelStart = new System.Windows.Forms.Label();
            this.btNajava = new System.Windows.Forms.Button();
            this.btRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(55, 99);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(359, 20);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "За да го користите системот претходно:";
            // 
            // btNajava
            // 
            this.btNajava.Location = new System.Drawing.Point(59, 178);
            this.btNajava.Name = "btNajava";
            this.btNajava.Size = new System.Drawing.Size(175, 53);
            this.btNajava.TabIndex = 1;
            this.btNajava.Text = "Најавете се!";
            this.btNajava.UseVisualStyleBackColor = true;
            this.btNajava.Click += new System.EventHandler(this.btNajava_Click);
            // 
            // btRegistracija
            // 
            this.btRegistracija.Location = new System.Drawing.Point(239, 178);
            this.btRegistracija.Name = "btRegistracija";
            this.btRegistracija.Size = new System.Drawing.Size(175, 53);
            this.btRegistracija.TabIndex = 2;
            this.btRegistracija.Text = "Регистрирајте се!";
            this.btRegistracija.UseVisualStyleBackColor = true;
            this.btRegistracija.Click += new System.EventHandler(this.btRegistracija_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 321);
            this.Controls.Add(this.btRegistracija);
            this.Controls.Add(this.btNajava);
            this.Controls.Add(this.labelStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStart";
            this.Text = "Најава во системот";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button btNajava;
        private System.Windows.Forms.Button btRegistracija;
    }
}

