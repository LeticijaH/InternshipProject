using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Piece
    {
        private int _serialNum;
        private int _partID;
        private int _operatorID;
        private DateTime _time;
        private StringUsedMaterials _stringUsedMaterials;
        private List<Property> _properties;
        public int serialNum { get { return _serialNum; } }
        public int partId { get { return _partID; } set { _partID = value; } }
        public int operatorID { get { return _operatorID; } }
        public DateTime time { get { return _time; } }
        
        public StringUsedMaterials stringUsedMaterials { get { return _stringUsedMaterials; } }
        public List<Property> Properties { get { return _properties; } set { _properties = value; } }
        public Piece(int SerialNum, int PartID, int OperatorID, DateTime dateTime)
        {
            _serialNum = SerialNum;
            _partID = PartID;
            _operatorID = OperatorID;
            _time = dateTime;
        }
       
        public Piece(int SerialNum, StringUsedMaterials stringUsed)
        {
            _serialNum = SerialNum;
            _stringUsedMaterials = stringUsed;
        }
       
    }
}
