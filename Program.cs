namespace LAB05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(10, 5, 4);
            box1.PrintBox();
            Console.WriteLine($"Объем 100 помещается? {box1.IsFit(100)}");
            Console.WriteLine($"Объем 250 помещается? {box1.IsFit(250)}");
            box1.L = 20;
            Console.WriteLine($"Новое значение длины: {box1.L}");
            box1.PrintBox();

            Console.WriteLine();

            Box box2 = new Box(3, 3, 3);
            box2.PrintBox();
            Console.WriteLine($"Объем 100 помещается? {box2.IsFit(100)}");
            Console.WriteLine($"Объем 250 помещается? {box2.IsFit(250)}");
            box2.W = 5;
            Console.WriteLine($"Новое значение ширины: {box2.W}");
            box2.PrintBox();

            Console.WriteLine();

            Box box3 = new Box(8, 6, 5);
            box3.PrintBox();
            Console.WriteLine($"Объем 100 помещается? {box3.IsFit(100)}");
            Console.WriteLine($"Объем 250 помещается? {box3.IsFit(250)}");
            box3.H = 3;
            Console.WriteLine($"Новое значение высоты: {box3.H}");
            box3.PrintBox();

            Console.WriteLine();

            try
            {
                box1.L = -5;
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                Box InvalidBox = new Box(10, 0, 5);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Ошибка создания коробки: {ex.Message}");
            }
        }
    }
}
