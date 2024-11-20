using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1.Models
{
    public class NoNumeroException: ApplicationException
    {
        public NoNumeroException(): base("dio error") 
        { }
        public NoNumeroException(string message) : base(message)
        {
        }
        public NoNumeroException(string msj,Exception ex) : base(msj,ex) { }
    }
}
