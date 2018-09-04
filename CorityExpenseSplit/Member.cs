using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorityExpenseSplit
{
    public class Member : IMember
    {
        private List<decimal> _expenses;

        public Member()
        {
            _expenses = new List<decimal>();
        }

        /// <summary>
        /// Add expense to member account
        /// </summary>
        /// <param name="index"></param>
        /// <param name="expense"></param>
        public void AddExpense(decimal expense)
        {
            if (expense > 0)
            {
                _expenses.Add(expense);
            }
            else
            {
                throw new Exception("Expense can not be negative");
            }
        }

        public int ExpenseCount
        {
            get { return _expenses.Count(); }
        }

        /// <summary>
        /// Total spent amount by member
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalExpense()
        {
            return _expenses.Sum();
        }
    }
}
