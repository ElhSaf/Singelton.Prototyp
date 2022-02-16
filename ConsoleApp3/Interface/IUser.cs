using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Protoyp.Interface
{  // denna interface måste skapas mot en klass i det här fallet Klass User.
   internal interface IUser  //När det börjar med stort I är det alltid interface    //interface klass måste man ändra från klass "interfave"
    {
        public void ShowName();     //skapr metoder som sk användas
        public void PrintInfo(); // samma här

        public int Id { get; set; }



    }
}
