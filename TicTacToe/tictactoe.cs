using System;
//using static System.Console;

namespace TicTacToe
{
    class tictactoe
    {
        protected static int origRow;
        protected static int origCol;

        // 지정 위치에 그리기 함수
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        // 모양 그리기 함수
        public static void PaintShape(string shape)
        {
            for (int i = 0; i < 9; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        WriteAt(shape, 2, 1);
                        break;
                    case "2":
                        WriteAt(shape, 6, 1);
                        break;
                    case "3":
                        WriteAt(shape, 10, 1);
                        break;
                    case "4":
                        WriteAt(shape, 2, 3);
                        break;
                    case "5":
                        WriteAt(shape, 6, 3);
                        break;
                    case "6":
                        WriteAt(shape, 10, 3);
                        break;
                    case "7":
                        WriteAt(shape, 2, 5);
                        break;
                    case "8":
                        WriteAt(shape, 6, 5);
                        break;
                    case "9":
                        WriteAt(shape, 10, 5);
                        break;
                }
                WriteAt(" ", 0, 10);
                Console.SetCursorPosition(0, 10);
            }
        }

        static void Main(string[] args)
        {
            // Clear the screen, then save the top and left coordinates.
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            // 칸 숫자 그리기
            WriteAt("1", 0, 0);
            WriteAt("2", 4, 0);
            WriteAt("3", 8, 0);
            WriteAt("4", 0, 2);
            WriteAt("5", 4, 2);
            WriteAt("6", 8, 2);
            WriteAt("7", 0, 4);
            WriteAt("8", 4, 4);
            WriteAt("9", 8, 4);

 
            // 가로선 그리기
            WriteAt("---", 1, 0);
            WriteAt("---", 5, 0);
            WriteAt("---", 9, 0);
            WriteAt("---", 1, 2);
            WriteAt("---", 5, 2);
            WriteAt("---", 9, 2);
            WriteAt("---", 1, 4);
            WriteAt("---", 5, 4);
            WriteAt("---", 9, 4);
            WriteAt("---", 1, 6);
            WriteAt("---", 5, 6);
            WriteAt("---", 9, 6);

            // 세로선 그리기
            WriteAt("|", 0, 1);
            WriteAt("|", 4, 1);
            WriteAt("|", 8, 1);
            WriteAt("|", 12, 1);
            WriteAt("|", 0, 3);
            WriteAt("|", 4, 3);
            WriteAt("|", 8, 3);
            WriteAt("|", 12, 3);
            WriteAt("|", 0, 5);
            WriteAt("|", 4, 5);
            WriteAt("|", 8, 5);
            WriteAt("|", 12, 5);

            // 꼭짓점 그리기
            WriteAt("+", 12, 0);
            WriteAt("+", 12, 2);
            WriteAt("+", 12, 4);
            WriteAt("+", 12, 6);
            WriteAt("+", 0, 6);
            WriteAt("+", 4, 6);
            WriteAt("+", 8, 6);


            WriteAt("Done", 0, 9);
            Console.WriteLine();    // 방금 커서가 있던 곳에서 다음줄로 넘어가게 하는 듯. 이걸 안해주면 아래처럼 커서 포지션 다시 정해야 함.

            // Console.SetCursorPosition(0, 6);
            PaintShape("O");



        }
    }
}
    
