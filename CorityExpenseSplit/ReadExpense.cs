using System;
using System.Collections.Generic;
using System.IO;

namespace CorityExpenseSplit
{
    class ReadExpense : IReadExpense
    {
        private StreamReader _sr;
        private List<ITripGroup> _tripGroups;
        public ReadExpense(string file)
        {
            _tripGroups = new List<ITripGroup>();
            if (File.Exists(file))
            {
                _sr = new StreamReader(file);
                SetTripGroup();
            }
        }

        public List<ITripGroup> GetTripGroups()
        {
            return _tripGroups;
        }
        private void SetTripGroup()
        {
            string line = string.Empty;
            TripGroup tripGroup;
            line = _sr.ReadLine();
            do
            {
                tripGroup = new TripGroup();
                SetMembers(tripGroup,int.Parse(line));
                line = _sr.ReadLine();
                _tripGroups.Add(tripGroup);
            } while (line != null && line != "0");
            _sr.Close();
        }
        private void SetMembers(TripGroup tripGroup,int count)
        {
            Member member;
            for (int i = 0; i < count; i++)
            {
                member = new Member();
                SetExpenses(member, int.Parse(_sr.ReadLine()));
                tripGroup.AddMember( member);
            }
        }
        private void SetExpenses(Member member, int expenseCount)
        {
            for (int i = 0; i < expenseCount; i++)
            {
                member.AddExpense(decimal.Parse(_sr.ReadLine()));
            }
        }
    }
}
