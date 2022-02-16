using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Protoyp.Interface
{


    class User : IUser

    {
        private int _id;
        private int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        int IUser.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowName()
        {
            throw new NotImplementedException();
        }

        public void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
