using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class LinkedList
    {
        private LinkedListNode top;

        public void Push(BookNode data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            newNode.Next = top;
            top = newNode;
        }

        public void DisplayItems()
        {
            LinkedListNode current = top;
            while (current != null)
            {
                Console.WriteLine($"Mã số: {current.Data.MaSo}, Tên sách: {current.Data.TenSach}, Số lượng: {current.Data.SoLuong}");
                current = current.Next;
            }
        }
    }
}
