using System;

namespace Schedule
{
    /*
 * 4-week month
 * 3 slots per day, in order
 * Bench - not allocated but can be summoned
 * 
 * FullTime 4 x 5days/week AMHP
 * Matt, Chris, Rebecca, Sarah
 * 
 * One 1st, one 2nd, one 3rd, and 2 bench
 * 
 * Part time
 * Emma 1 x 3days/week, Wed/Thu/Fri, sometimes not 1st Weds
 * 
 * Sessional 4 x 1day/week - Rob, Heidi, Alex, Lucy
 * Rob Tuesday every week
 * Heidi never Thursday
 * Lucy never Monday, exactly 3 per month
 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var rota = new Rota();

            // TODO run this x100 and compare results somehow
            // build a csv file?
            var results = rota.CreateRota();

            var heading = string.Join(',', { 
                "Wk1", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                "Wk2", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                "Wk3", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                "Wk4", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        }
    }
}
