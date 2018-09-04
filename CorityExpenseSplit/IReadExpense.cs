using System.Collections.Generic;

namespace CorityExpenseSplit
{
    interface IReadExpense
    {
        List<ITripGroup> GetTripGroups();
    }
}