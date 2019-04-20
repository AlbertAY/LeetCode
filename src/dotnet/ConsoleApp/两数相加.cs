using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Generic.Dictionary<TKey, TValue>;

namespace ConsoleApp
{
    public class 两数相加
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode listNode = new ListNode(0);

            List<int> result = new List<int>();

            GetSumValue(l1,l2, result);

            result.

            return listNode;
        }


        public void GetSumValue(ListNode l1, ListNode l2, Dictionary<int,int> result)
        {
            if (l1 == null && l2 == null)
            {
                return;
            }
            KeyCollection indexs = result.Keys;
            result.Add( l1?.val ?? 0 + l2?.val ?? 0);
            GetSumValue(l1.next,l2.next, result);
        }


        /// <summary>
        /// 获取链表深度
        /// </summary>
        /// <param name="listNode"></param>
        /// <returns></returns>
        public int GetDeep(ListNode listNode)
        {
            if (listNode.next == null)
            {
                return 1;
            }
            else
            {
                return GetDeep(listNode.next) + 1;
            }
        }

        public ListNode GetDeepNode(ListNode listNode, int nowDeep, int deepIndex)
        {
            if (nowDeep == deepIndex)
            {
                return listNode;
            }
            return GetDeepNode(listNode.next, nowDeep++, deepIndex);
        }





        public class ListNode
        {
            public int val;

            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
