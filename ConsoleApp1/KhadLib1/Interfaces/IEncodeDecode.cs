using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace KhadLib1.Interfaces
{
     interface IEncodeDecode
    {
        string Encrypt(string source);
        
        string Decrypt(string source);
    }
}
