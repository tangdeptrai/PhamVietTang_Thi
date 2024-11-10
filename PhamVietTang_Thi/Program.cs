// See https://aka.ms/new-console-template for more information
using PhamVietTang_Thi;

//23DH113104_PhamVietTang
class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        BookBST bookBST = new BookBST();
        int choice;

        do
        {
            Console.WriteLine("\n--- Quản lý danh sách đầu sách trong thư viện ---");
            Console.WriteLine("1. Thêm đầu sách mới");
            Console.WriteLine("2. Tìm kiếm đầu sách");
            Console.WriteLine("3. Lưu tất cả đầu sách vào danh sách liên kết và in ra");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn của bạn: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.Write("Nhập mã số sách: ");
                        int maSo = int.Parse(Console.ReadLine());
                        Console.Write("Nhập tên sách: ");
                        string tenSach = Console.ReadLine();
                        Console.Write("Nhập số lượng: ");
                        int soLuong = int.Parse(Console.ReadLine());

                        bookBST.AddBook(maSo, tenSach, soLuong);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ, vui lòng nhập lại.");
                    }
                    break;

                case 2:
                    try
                    {
                        Console.Write("Nhập mã số sách cần tìm kiếm: ");
                        int searchMaSo = int.Parse(Console.ReadLine());
                        bookBST.SearchBook(searchMaSo);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ, vui lòng nhập lại.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Danh sách đầu sách theo dạng stack:");
                    LinkedList list = bookBST.SaveToLinkedList();
                    list.DisplayItems();
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        } while (choice != 0);
    }
}

