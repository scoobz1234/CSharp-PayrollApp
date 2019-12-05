using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollAppForms.Classes
{
    class PhoneNumber
    {
        private int _areaCode;
        private int _prefix;
        private int _lineNumber;

        public PhoneNumber() { }

        public PhoneNumber(int areaCode, int prefix, int lineNum)
        {
            this._areaCode = areaCode;
            this._prefix = prefix;
            this._lineNumber = lineNum;

        }

        public int AreaCode {
            get { return _areaCode; }
            set { _areaCode = value; }
        }

        public int Prefix {
            get { return _prefix; }
            set { _prefix = value; }
        }

        public int LineNumber {
            get { return _lineNumber; }
            set { _lineNumber = value; }
        }

        public override string ToString()
        {
            return "(" + _areaCode + ") " + _prefix + "-" + _lineNumber;
        }

    }
}
