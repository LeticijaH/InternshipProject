
namespace Zadaca2
{
    partial class ReportForm
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
            this.reportViewerPieces = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPieces
            // 
            this.reportViewerPieces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPieces.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPieces.Name = "reportViewerPieces";
            this.reportViewerPieces.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewerPieces.ServerReport.BearerToken = null;
            this.reportViewerPieces.ServerReport.ReportPath = "/ReportPieces";
            this.reportViewerPieces.ServerReport.ReportServerUrl = new System.Uri("http://comp144/ReportServer", System.UriKind.Absolute);
            this.reportViewerPieces.Size = new System.Drawing.Size(1221, 574);
            this.reportViewerPieces.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 574);
            this.Controls.Add(this.reportViewerPieces);
            this.Name = "ReportForm";
            this.Text = "Извештај за одредено парче";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPieces;
    }
}