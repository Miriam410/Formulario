using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class TransacctionResult
    {
        private int _id;
        [DataMember]
        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }

        private string _error;
        [DataMember]
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        private bool _isOk;
        [DataMember]
        public bool IsOK
        {
            get { return _isOk; }
            set { _isOk = value; }
        }

    }
}
