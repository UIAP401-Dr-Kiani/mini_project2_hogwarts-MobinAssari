using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Student : AuthorizedPerson
    {
        private String _unitPassed;
        private String _term;
        private String _roomNumber;
    }
}
