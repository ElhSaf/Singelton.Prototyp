using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns

{
    class InvitationCard
    {
        public string To;
        public string Title;
        public DateTime Date;

        public InvitationCard()   // skapar tom konstruktor
        {
             
        }

        public InvitationCard CloneCard(InvitationCard obj)  // den tar in ett skapt kort i andra fall är det string eller int nu ett helt ibjekt
        {
            return (InvitationCard)this.MemberwiseClone();    //skapar kopier av samma kort. skpara flera kopior av Elham kortet. Nu ska vi göra så att det blir flera kort men till olika personer.
        }
    public void PrintCard()
    {
        Console.WriteLine("to: " + To);
        Console.WriteLine(Title);
        Console.WriteLine("When?!: " + Date.ToString());
        Console.WriteLine();
    }

    }
    


}
