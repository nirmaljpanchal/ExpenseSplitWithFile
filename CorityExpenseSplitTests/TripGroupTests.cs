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
    public class TripGroupTests
    {
        TripGroup tripGroup;
        public TripGroupTests()
        {
            tripGroup = new TripGroup();
            Member member = new Member();
            member.AddExpense(10);
            member.AddExpense(20);
            tripGroup.AddMember(member);
            member = new Member();
            member.AddExpense(15);
            member.AddExpense(15.01m);
            member.AddExpense(3);
            member.AddExpense(3.01m);
            tripGroup.AddMember( member);

            member = new Member();
            member.AddExpense(5);
            member.AddExpense(9);
            member.AddExpense(4);
            tripGroup.AddMember(member);
        }

        [TestMethod()]
        public void AddMemberTest()
        {
            Assert.AreEqual(tripGroup.MemberCount, 3);
        }

        [TestMethod()]
        public void GetMembersBalanceTest()
        {
            decimal[] balance=tripGroup.GetMembersBalance();
            Assert.AreEqual(Decimal.Round(balance[0],2),-1.99m);
            Assert.AreEqual(Decimal.Round(balance[1],2), -8.01m);
            Assert.AreEqual(Decimal.Round(balance[2],2), 10.01m);
        }
    }
}