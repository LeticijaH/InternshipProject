using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca2
{
    public partial class ReportForm : Form
    {
        private int _pieceID;
        private int _partID;
        private int _serialNumber;
        public int PieceID { get { return _pieceID; } }
        public int PartID { get { return _partID; } }
        public int SerialNumber { get { return _serialNumber; } }
        public ReportForm(int idPart, int idPiece, int serialNumber)
        {
            InitializeComponent();
            _partID = idPart;
            _pieceID = idPiece;
            _serialNumber = serialNumber;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportViewerPieces.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            Microsoft.Reporting.WinForms.ServerReport sr = reportViewerPieces.ServerReport;
            sr.ReportServerUrl = new Uri("http://comp144/ReportServer");
            sr.ReportPath = @"/ReportPieces";

            ReportParameter serialNumber = new ReportParameter();
            serialNumber.Name = "serialNumber";
            serialNumber.Values.Add(SerialNumber.ToString());

            ReportParameter idPiece = new ReportParameter();
            idPiece.Name = "idPiece";
            idPiece.Values.Add(PieceID.ToString());

            ReportParameter idPart = new ReportParameter();
            idPart.Name = "idPart";
            idPart.Values.Add(PartID.ToString());

            List<ReportParameter> parameterList = new List<ReportParameter>();

            parameterList.Add(serialNumber);
            parameterList.Add(idPart);
            parameterList.Add(idPiece);

            reportViewerPieces.ServerReport.SetParameters(parameterList);

            this.reportViewerPieces.RefreshReport();
        }

    }
}
