using System.Collections.Generic;

namespace Schedule
{
    public class Rota
    {
        Amhp Matt, Chris, Rebecca, Sarah, Emma, Rob, Heidi, Alex, Lucy;

        private List<Amhp> Employees = new List<Amhp>();

        public int DaysInRota = 28;
        public int SlotsPerRota = 12;
        public int DaysInWeek = 5;
        public int SlotsPerDay = 3;
        public SortedList<Slot, Amhp> Slots;

        // dayNum, slot, employee
        public List<TimetableEntry> TimetableEntries = new List<TimetableEntry>();

        public Rota()
        {
            Matt = new Amhp("Matt", EmpType.FullTime, 5, 28, FullTimeRequiredDays);
            Chris = new Amhp("Chris", EmpType.FullTime, 5, 28, FullTimeRequiredDays);
            Rebecca = new Amhp("Rebecca", EmpType.FullTime, 5, 28, FullTimeRequiredDays);
            Sarah = new Amhp("Sarah", EmpType.FullTime, 5, 28, FullTimeRequiredDays);
            Emma = new Amhp("Emma", EmpType.PartTime, 3, 12, FullTimeRequiredDays);
            Rob = new Amhp("Rob", EmpType.Sessional, 1, 4, FullTimeRequiredDays);
            Heidi = new Amhp("Heidi", EmpType.Sessional, 1, 4, FullTimeRequiredDays);
            Alex = new Amhp("Alex", EmpType.Sessional, 1, 4, FullTimeRequiredDays);
            Lucy = new Amhp("Lucy", EmpType.Sessional, 1, 4, FullTimeRequiredDays);

            Employees.Add(Matt);
            Employees.Add(Chris);
            Employees.Add(Rebecca);
            Employees.Add(Sarah);
            Employees.Add(Emma);
            Employees.Add(Rob);
            Employees.Add(Heidi);
            Employees.Add(Alex);
            Employees.Add(Lucy);
        }

        // Rules delegates
        public int FullTimeRequiredDays()
        {
            return 5 * 4;
        }
        public int PartTimeRequiredDays(Amhp amhp)
        {
            // TODO Emma 1 x 3days / week, Wed / Thu / Fri, sometimes not 1st Weds
            return 3 * 4;
        }
        public int SessionalRequiredDays(Amhp amhp)
        {
            // Sessional 4 x 1day / week - Rob, Heidi, Alex, Lucy
            // Rob Tuesday every week
            // Heidi never Thursday
            // Lucy never Monday, exactly 3 per month
            return 1 * 4;
        }

        public List<TimetableEntry> CreateRota()
        {
            // Do the sessionals first until their rules are met - 
            // pick a random day, pick a random slot, check it won't break the Amhp rule

            // Then do the part-time until their rulesa re met

            // then do the full-time


            var lastAmhpsPicked = 
            // TODO the hard stuff
            for (int day = 1; day <= 28; day++)
            {
                for (int slot = 1; slot <= 3; slot++)
                {
                    // pick an Amhp at random
                    // if Amhp not in last 2 picked
                    // and Amhp rule is not met
                        // add Amhp to current slot
                }
            }

            return TimetableEntries;
        }
    }
}
