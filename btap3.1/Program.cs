using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thu nhat a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap so thu hai b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhập phép toán (+, -, *, /, %): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        try
        {
            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' or '%' when b == 0
                    => throw new DivideByZeroException(),
                '/' => a / b,
                '%' => a % b,
                _ => throw new ArgumentException("khong hop le!")
            };

            Console.WriteLine($"Kết quả: {result:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("khong the chia cho 0!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}
