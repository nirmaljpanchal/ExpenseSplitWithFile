using System;
using System.Collections.Generic;
using System.IO;

namespace CorityExpenseSplit
{
    class WriteExpense : IWriteExpense
    {
        string _file = string.Empty;
        private StreamWriter _sw;
        private List<TripGroup> _tripGroups;
        public WriteExpense(string file)
        {
            _file = file;
        }

        public void WriteTripBalance(List<ITripGroup> tripGroups)
        {
            if (!File.Exists(_file))
            {
                _sw = File.CreateText(_file);
            }
            else
            {
                _sw = new StreamWriter(_file);
            }
            foreach (var item in tripGroups)
            {
                WriteMemberBalance(item.GetMembersBalance());
                _sw.WriteLine("");
            }
            _sw.Close();
        }
        private void WriteMemberBalance(decimal[] expence)
        {
            string fmt2 = "$#,##0.00;($#,##0.00)";
            for (int i = 0; i < expence.Length; i++)
            {
                _sw.WriteLine(expence[i].ToString(fmt2));
            }
        }
    }
}
