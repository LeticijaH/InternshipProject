using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class ReportPiece
    {
        private int _pieceID;
        private int _partID;
        private int _serialNumber;
        private DateTime _timestamp;
        private string _userName;
        private string _usedMaterial;
        private string _manufactorer;
        private List<Property> _props;
        public int SerialNumber { get { return _serialNumber; }}
        public int PartID { get { return _partID; } }
        public string Operator { get { return _userName; } }
        public DateTime Time { get { return _timestamp; } }
        public int PieceID { get { return _pieceID; } }
        public string Material { get { return _usedMaterial; } }
        public string Manufactorer { get { return _manufactorer; } }
        public List<Property> Properties { get { return _props; } set { _props = value; } }
        public ReportPiece(int pieceID,int partID,int serialNumber,DateTime time,string mat,string man,string operatorName)
        {
            _serialNumber = serialNumber;
            _pieceID = pieceID;
            _partID = partID;
            _userName = operatorName;
            _timestamp = time;
            _usedMaterial = mat;
            _manufactorer = man;
        }

    }
}
