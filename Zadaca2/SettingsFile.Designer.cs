
namespace Zadaca2
{
    partial class SettingsFileForm
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
            this.labelDataBServer = new System.Windows.Forms.Label();
            this.labelDataBName = new System.Windows.Forms.Label();
            this.btSettingsFileCreate = new System.Windows.Forms.Button();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.tbDataBaseName = new System.Windows.Forms.TextBox();
            this.saveFileXML = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelDataBServer
            // 
            this.labelDataBServer.AutoSize = true;
            this.labelDataBServer.Location = new System.Drawing.Point(53, 63);
            this.labelDataBServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataBServer.Name = "labelDataBServer";
            this.labelDataBServer.Size = new System.Drawing.Size(76, 20);
            this.labelDataBServer.TabIndex = 0;
            this.labelDataBServer.Text = "Сервер:";
            // 
            // labelDataBName
            // 
            this.labelDataBName.AutoSize = true;
            this.labelDataBName.Location = new System.Drawing.Point(53, 127);
            this.labelDataBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataBName.Name = "labelDataBName";
            this.labelDataBName.Size = new System.Drawing.Size(101, 20);
            this.labelDataBName.TabIndex = 1;
            this.labelDataBName.Text = "Дата база:";
            // 
            // btSettingsFileCreate
            // 
            this.btSettingsFileCreate.Location = new System.Drawing.Point(185, 194);
            this.btSettingsFileCreate.Name = "btSettingsFileCreate";
            this.btSettingsFileCreate.Size = new System.Drawing.Size(123, 37);
            this.btSettingsFileCreate.TabIndex = 2;
            this.btSettingsFileCreate.Text = "Зачувај";
            this.btSettingsFileCreate.UseVisualStyleBackColor = true;
            this.btSettingsFileCreate.Click += new System.EventHandler(this.btSettingsFileCreate_Click);
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(161, 60);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(214, 27);
            this.tbServerName.TabIndex = 3;
            // 
            // tbDataBaseName
            // 
            this.tbDataBaseName.Location = new System.Drawing.Point(161, 124);
            this.tbDataBaseName.Name = "tbDataBaseName";
            this.tbDataBaseName.Size = new System.Drawing.Size(214, 27);
            this.tbDataBaseName.TabIndex = 4;
            // 
            // saveFileXML
            // 
            this.saveFileXML.DefaultExt = "xml";
            this.saveFileXML.FileName = "Save Settings File";
            // 
            // SettingsFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 280);
            this.Controls.Add(this.tbDataBaseName);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.btSettingsFileCreate);
            this.Controls.Add(this.labelDataBName);
            this.Controls.Add(this.labelDataBServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsFileForm";
            this.Text = "Конектирање со дата база";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataBServer;
        private System.Windows.Forms.Label labelDataBName;
        private System.Windows.Forms.Button btSettingsFileCreate;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.TextBox tbDataBaseName;
        private System.Windows.Forms.SaveFileDialog saveFileXML;
    }
}