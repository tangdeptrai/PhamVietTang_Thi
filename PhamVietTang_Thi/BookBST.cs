using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class BookBST
    {
        private BookNode root;

        // Thêm đầu sách mới vào cây
        public void AddBook(int maSo, string tenSach, int soLuong)
        {
            root = AddBookRecursive(root, maSo, tenSach, soLuong);
        }

        private BookNode AddBookRecursive(BookNode node, int maSo, string tenSach, int soLuong)
        {
            if (node == null)
            {
                Console.WriteLine("Đã thêm đầu sách thành công.");
                return new BookNode(maSo, tenSach, soLuong);
            }

            if (maSo < node.MaSo)
                node.Left = AddBookRecursive(node.Left, maSo, tenSach, soLuong);
            else if (maSo > node.MaSo)
                node.Right = AddBookRecursive(node.Right, maSo, tenSach, soLuong);
            else
                Console.WriteLine("Mã số này đã tồn tại. Không thêm vào.");

            return node;
        }

        // Tìm kiếm đầu sách theo mã số
        public void SearchBook(int maSo)
        {
            BookNode result = SearchBookRecursive(root, maSo);
            if (result != null)
                Console.WriteLine($"Mã số: {result.MaSo}, Tên sách: {result.TenSach}, Số lượng: {result.SoLuong}");
            else
                Console.WriteLine("Không tìm thấy đầu sách với mã số này.");
        }

        private BookNode SearchBookRecursive(BookNode node, int maSo)
        {
            if (node == null || node.MaSo == maSo)
                return node;

            if (maSo < node.MaSo)
                return SearchBookRecursive(node.Left, maSo);

            return SearchBookRecursive(node.Right, maSo);
        }

        // Duyệt cây theo thứ tự NLR và lưu vào danh sách liên kết đơn theo dạng stack
        public LinkedList SaveToLinkedList()
        {
            LinkedList list = new LinkedList();
            TraverseNLRAndPush(root, list);
            return list;
        }

        private void TraverseNLRAndPush(BookNode node, LinkedList list)
        {
            if (node != null)
            {
                list.Push(node);
                TraverseNLRAndPush(node.Left, list);
                TraverseNLRAndPush(node.Right, list);
            }
        }
    }
}
