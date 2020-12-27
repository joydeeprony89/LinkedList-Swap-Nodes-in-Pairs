using System;

namespace LinkedList_Swap_Nodes_in_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            var node = SwapPairs_Recursive(head);
            while (node != null)
            {

                Console.WriteLine(node.val);
                node = node.next;
            }
        }

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

        static ListNode SwapPairs(ListNode head)
        {
            if (head == null) return head;
            ListNode current = head;
            ListNode next = current.next;
            while (current != null && next != null)
            {
                int temp = current.val;
                current.val = next.val;
                next.val = temp;
                current = next.next;
                next = current?.next;
            }

            return head;
        }

        static ListNode SwapPairs_Recursive(ListNode head)
        {
            if (head == null) return head;

            ListNode next = head.next;
            head.next = SwapPairs_Recursive(head.next.next);
            next.next = head;

            return next;
        }
    }
}
