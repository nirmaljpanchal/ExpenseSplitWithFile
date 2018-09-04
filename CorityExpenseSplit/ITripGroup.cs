namespace CorityExpenseSplit
{
    public interface ITripGroup
    {
        int MemberCount { get; }
        void AddMember( IMember member);
        decimal[] GetMembersBalance();
    }
}