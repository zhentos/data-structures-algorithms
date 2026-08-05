namespace RemoveLinkedListElements_203;

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
        ListNode head = new ListNode(1,
         new ListNode(2,
             new ListNode(6,
                 new ListNode(3,
                     new ListNode(4)))));

        var result = RemoveElements(head, 6);

    }

    public static ListNode RemoveElements(ListNode head, int val)
    {
        if (head is null || head.next is null)
            return head;

        var current = head;

        while (current.next != null)
        {
            if (current.val == val)
            {
                if (current.next.next == null)
                {
                    current.next = null;
                }
                else
                {
                    current = current.next.next;
                }
            }
            current.next = current.next == null ? null : current.next.next;
        }
        return current;
    }
}
