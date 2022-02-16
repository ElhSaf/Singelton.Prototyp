using System;


namespace Patterns

{
    class Program
    {
        static void Main(string[] args)
        {     
            //SingelTone
            //SKapa objekt av typen Singlton där kontruktorn är Public 
            /* Singlton s1 = new Singlton("Jim");
             s1.PrintInfo();

             Singlton s2 = new Singlton("ELham");
             s2.PrintInfo();
            */
            // SKAPA objekt när kontruktorn är Private
            /* Singlton s1 = Singlton.GetInstance("Jim");
             s1.PrintInfo();

             Singlton s2 = Singlton.GetInstance("Jim");
             s1.PrintInfo();
            */

            /*
            //Prototyp
            InvitationCard invitation = new();     //lägger till värden i objektet och skpaar objekt
            invitation.To = "Elham";
            invitation.Title = "Party";
            invitation.Date = new DateTime(2022, 02, 27);

            invitation.PrintCard(); // ropar på objektet som skpats och skriver ut 

            string[] friends = { "leo", "Elham", "Maria" };  //skapr en lista av namn som kan användas för korten.
            InvitationCard[] invitationCards = new InvitationCard[3];  // denna har en lista  alla kort 

            for (int i = 0; i < friends.Length; i++)  //skapa en loop som skapar flera kort och ändrar namnet på korten och lägger till dom i kort listan för massutskick
            {
                invitationCards[i] = invitation.CloneCard(invitation); // skapar kort av invitation objekt och ropar på clone metodenså det blir en kopia.
                invitationCards[i].To = friends[i];  // går på index noll och väljer parameter TO för där står namnet och så byter jag namn till index 0 från friends listan.
                //eftersom det är en loop så kommer den fortsätta ändra resten också


            }
            foreach (var item in invitationCards)  // här loopar vi igenom kort listan efter att namnet har ändrats och skriver ut, så har flera kort nu med namn från friends listan 
            {
                item.PrintCard(); 
            }
            */
        }
        
    }
}
