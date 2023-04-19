using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class AuthorizedPerson
    {
        private int _roomNumber;
        private string _lessonSchedule;
        private enum _pet
        {
            owl,
            cat,
            rat
        }
        private Group _group;
        private Boolean _isHavingBaggage;
        private enum _role
        {
            student, teacher
        }
        private List<string> _mailBox;
    }
}
