namespace практика3

{
    internal class Programm
    {
        static int[] FirstOctava = { 32, 34, 39, 40, 41, 43, 46, 49, 55, 58, 61, 63 };
        static int[] SecondOctava = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        static int[] ThirdOctava = { 130, 138, 146, 155, 165, 174, 185, 196, 207, 220, 233, 246 };
        static int[] FourthOctava = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        static int[] FifthOctava = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

        static void Main(string[] args)
        {
            Console.WriteLine("выбирите октаву: f1 f2 f3 f4 f5 \n" +
                "клавиши: d r f t g y h u j i k o ");
            while (true)
            {
                int[] piano = octava();
                if (piano == FirstOctava)
                {
                    Console.WriteLine("первая октава");
                    bip(piano);
                }
                else if (piano == SecondOctava)
                {
                    Console.WriteLine("вторая октава ");
                    bip(piano);
                }
                else if (piano == ThirdOctava)
                {
                    Console.WriteLine("третья октава ");
                    bip(piano);
                }
                else if (piano == FourthOctava)
                {
                    Console.WriteLine("четвертая октава ");
                    bip(piano);
                }
                else if (piano == FifthOctava)
                {
                    Console.WriteLine("пятая октава ");
                    bip(piano);
                }
            }
          

        }
        static int[] octava()
        {
            int[] knopki = new int[13];
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("первая октава");
                    knopki = FirstOctava;
                    return knopki;
                }
                else if (Key.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("вторая октава");
                    knopki = SecondOctava;
                    return knopki;
                }
                else if (Key.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("третья  октава");
                    knopki = ThirdOctava;
                    return knopki;
                }
                else if (Key.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("четвертая  октава");
                    knopki = FourthOctava;
                    return knopki;
                }
                else if (Key.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("пятая  октава");
                    knopki = FifthOctava;
                    return knopki;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("выбирите октаву: f1 f2 f3 f4 f5 \n" +
        "клавиши: d r f t g y h u j i k o ");
                    return knopki;
                }
            }
        }
        private static int[] bip(int[] piano)
        {
            int[] knopki = new int[13];
            while (true)
            {
                ConsoleKey zvuk = Console.ReadKey().Key;
                switch (zvuk)
                {
                    case ConsoleKey.D:
                        Console.Beep(piano[0], 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        Console.Beep(piano[1] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(piano[2] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(piano[3] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Beep(piano[4] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(piano[5] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(piano[6] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(piano[7] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        Console.Beep(piano[8] + 1000, 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(piano[9], 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(piano[10], 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.O:
                        Console.Beep(piano[11], 400);
                        Console.Clear();
                        break;
                    case ConsoleKey.F1:
                        piano = FirstOctava;
                        return piano;
                        break;
                    case ConsoleKey.F2:
                        piano = SecondOctava;
                        return piano;
                        break;
                    case ConsoleKey.F3:
                        piano = ThirdOctava;
                        return piano;
                        break;
                    case ConsoleKey.F4:
                        piano = FourthOctava;
                        return piano;
                        break;
                    case ConsoleKey.F5:
                        piano = FifthOctava;
                        return piano;
                        break;
                    default:
                        Console.Clear();
                        break;


                }
            }
        }
    }

}

