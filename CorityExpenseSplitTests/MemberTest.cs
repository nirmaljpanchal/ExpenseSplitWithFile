using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorityExpenseSplit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorityExpenseSplit.Tests
{
    [TestClass()]
    public class MemberTests
    {
        Member member;
        public MemberTests()
        {
            member = new Member();
            member.AddExpense(15);
            member.AddExpense(15.01m);
            member.AddExpense(3);
            member.AddExpense(3.01m);
        }

        [TestMethod()]
        public void AddExpenseTest()
        {
            Assert.AreEqual(member.ExpenseCount, 4);
        }

        [TestMethod()]
        public void GetTotalExpenseTest()
        {
            Assert.AreEqual(Decimal.Round(member.GetTotalExpense(),2),36.02m);
        }
    }
}