public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        // Общий хвост: 8 -> 4 -> 5
        ListNode common = new ListNode(8,
            new ListNode(4,
                new ListNode(5)));

        // A: 4 -> 1 -> 8 -> 4 -> 5
        ListNode headA = new ListNode(4,
            new ListNode(1, common));

        // B: 5 -> 6 -> 1 -> 8 -> 4 -> 5
        ListNode headB = new ListNode(5,
            new ListNode(6,
                new ListNode(1, common)));

        var resutl = GetIntersectionNode(headA, headB); 
    }
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var seen = new HashSet<ListNode>();

        while (headA != null)
        {
            seen.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (seen.Contains(headB))
                return headB;

            headB = headB.next;
        }

        return null;
    }
}