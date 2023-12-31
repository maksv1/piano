namespace Piano
{
    class Program
    {
        static int[] currentOctave = new int[] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 }; // частота волны ноты в герцах для текущей октавы
        static int[][] octaves = new int[][] {
            new int[] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 }, // вторая октава
            new int[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 }, // третья октава
            new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 }, // четвёртая октава
            new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 },// пятая октава
            new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 }, // шестая октава
            new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 }, // седьмая октава
            new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }, // восьмая октава
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Пианино");
            Console.WriteLine("Переключение октав F2-F8");
            Console.WriteLine("Играть Q,W,E,R,T,Y,U,I,O,P,K,L");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F2)
                {
                    currentOctave = ChangeOctave(0);
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    currentOctave = ChangeOctave(1);
                }
                else if (key.Key == ConsoleKey.F4)
                {
                    currentOctave = ChangeOctave(2);
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    currentOctave = ChangeOctave(3);
                }
                else if (key.Key == ConsoleKey.F6)
                {
                    currentOctave = ChangeOctave(4);
                }
                else if (key.Key == ConsoleKey.F7)
                {
                    currentOctave = ChangeOctave(5);
                }
                else if (key.Key == ConsoleKey.F8)
                {
                    currentOctave = ChangeOctave(6);
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    PlaySound(0);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    PlaySound(1);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    PlaySound(2);
                }
                else if (key.Key == ConsoleKey.R)
                {
                    PlaySound(3);
                }
                else if (key.Key == ConsoleKey.T)
                {
                    PlaySound(4);
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    PlaySound(5);
                }
                else if (key.Key == ConsoleKey.U)
                {
                    PlaySound(6);
                }
                else if (key.Key == ConsoleKey.I)
                {
                    PlaySound(7);
                }
                else if (key.Key == ConsoleKey.O)
                {
                    PlaySound(8);
                }
                else if (key.Key == ConsoleKey.P)
                {
                    PlaySound(9);
                }
                else if (key.Key == ConsoleKey.K)
                {
                    PlaySound(10);
                }
                else if (key.Key == ConsoleKey.L)
                {
                    PlaySound(11);
                }
            }
        }

        static int[] ChangeOctave(int octaveIndex)
        {
            if (octaveIndex >= 0 && octaveIndex < octaves.Length)
            {
                return octaves[octaveIndex];
            }
            return currentOctave;
        }

        static void PlaySound(int noteIndex)
        {
            Console.Beep(currentOctave[noteIndex], 500);
        }
    }
}
