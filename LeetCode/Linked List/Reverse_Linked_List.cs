namespace LeetCode.Linked_List
{
    public class Reverse_Linked_List
    {
         //Definition for singly-linked list.
         public class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
         }

        //https://leetcode.com/problems/reverse-linked-list/
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode prev = null;
            ListNode current = head;
            ListNode next = current.next;
            current.next = null;
            while (next != null)
            {
                prev = current;
                current = next;
                next = current.next;
                current.next = prev;
            }
            return current;
        }
    }
}
