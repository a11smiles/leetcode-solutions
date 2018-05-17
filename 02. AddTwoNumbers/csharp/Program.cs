using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9) {
                next = new ListNode(4) {
                    next = new ListNode(1)
                }
            };

            ListNode l2 = new ListNode(3) {
                next = new ListNode(0) {
                    next = new ListNode(2)
                }
            };

            var solution = new Solution();
            var result = solution.AddTwoNumbers(l1, l2);
        }
    }

    class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(l1, l2, 0);
        }

        private ListNode Add(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0) return null;
            var value = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            return new ListNode(value % 10) { next = Add(l1?.next, l2?.next, value / 10) };
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
