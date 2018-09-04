using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorityExpenseSplit
{
    public class TripGroup : ITripGroup
    {
        private List<IMember> _members;

        public TripGroup()
        {
            _members = new List<IMember>();
        }

        public int MemberCount
        {
            get
            {
                return _members.Count;
            }
        }
        public void AddMember( IMember member)
        {
            _members.Add( member);
        }
        private decimal GetTotalExpenses()
        {
            decimal totalExpense = 0;
            for (int i = 0; i < _members.Count; i++)
            {
                totalExpense += _members[i].GetTotalExpense();
            }
            return totalExpense;
        }
        public decimal[] GetMembersBalance()
        {
            decimal[] balance = new decimal[_members.Count];
            decimal equalExpence = GetTotalExpenses() / _members.Count;
            for (int i = 0; i < _members.Count; i++)
            {
                balance[i] = equalExpence - _members[i].GetTotalExpense();
            }
            return balance;
        }
    }
}
