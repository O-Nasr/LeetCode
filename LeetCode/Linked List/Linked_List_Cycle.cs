namespace LeetCode.Linked_List
{
    //Definition for singly-linked list.
   /* public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }*/
    public class Linked_List_Cycle
    {
        //https://leetcode.com/problems/linked-list-cycle/
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && fast != null)
            {
                slow = slow.next;
                fast = fast.next?.next;
                if (slow == fast)
                {
                    if (slow != null || fast != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
