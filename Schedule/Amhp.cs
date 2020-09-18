using System;

namespace Schedule
{
    public class Amhp
    {
        public string Name { get; set; }
        public EmpType EmployeeType { get; set; }

        public int RequiredDaysPerWeek { get; set; }
        public int RequiredDaysPerMonth { get; set; }

        public Func<int> Rule;
        public int NumAllocatedDays { get; set; }

        public Amhp(string name, EmpType employeeType, int requiredDaysPerWeek, int requiredDaysPerMonth, Func<int> rule)
        {
            Name = name;
            EmployeeType = employeeType;
            RequiredDaysPerWeek = requiredDaysPerWeek;
            RequiredDaysPerMonth = requiredDaysPerMonth;
            Rule = rule;
        }

        public bool AreRulesMet()
        {
            throw new NotImplementedException();

            // TODO expand - consider making each empType a subclass
            if (EmployeeType == EmpType.FullTime) { }
            if (EmployeeType == EmpType.PartTime) { }
            if (EmployeeType == EmpType.Sessional) { }

            return false;
        }

        public bool SuggestedAmhpSlotSatisfiesRules(TimetableEntry timetableEntry)
        {
            throw new NotImplementedException();
            return false;
        }
    }
}
