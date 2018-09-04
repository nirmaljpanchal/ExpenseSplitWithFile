using System.Collections.Generic;

namespace CorityExpenseSplit
{
    interface IWriteExpense
    {
        void WriteTripBalance(List<ITripGroup> tripGroups);
    }
}