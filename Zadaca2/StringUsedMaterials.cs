using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class StringUsedMaterials
    {
        private string _type;
        private string  _materialTypeId;
        private string _manufacturerId;
        private string _pieceId;

        public string Type { get { return _type; } }
        public string MaterialTypeId { get { return _materialTypeId; } }
        public string ManufacturerId { get { return _manufacturerId; } }
        public string PieceId { get { return _pieceId; } }

        public StringUsedMaterials(string t,string mT,string mI,string pI)
        {
            _type = t;
            _materialTypeId = mT;
            _manufacturerId = mI;
            _pieceId = pI;
        }

    }
}
