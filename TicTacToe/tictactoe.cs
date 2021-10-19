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
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        // 모양 그리기 함수
        public static void PaintShape(string shape, string input)
        {
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
                default:
                    Console.WriteLine("1~9 사이의 번호로 다시 입력하세요:");
                    PaintShape(shape, input);
                    break;
            }
            WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
            Console.SetCursorPosition(0, 10);   // 순서 안내문 위치로 커서 이동 
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


            WriteAt("게임을 시작합니다", 0, 9);
            Console.WriteLine();    // 방금 커서가 있던 곳에서 다음줄로 넘어가게 하는 듯. 이걸 안해주면 아래처럼 커서 포지션 다시 정해야 함.

            // Console.SetCursorPosition(0, 6);


            // 다시 천천히 만들어보자.
            string shape;

            string one = null;
            string two = null;
            string three = null;
            string four = null;
            string five = null;
            string six = null;
            string seven = null;
            string eight = null;
            string nine = null;

            bool isThereWinner = false;

            for (int i=0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    shape = "O";
                }
                else
                {
                    shape = "X";
                }

                Console.WriteLine(shape + "차례입니다. 원하는 칸의 번호를 입력하세요: ");

                bool isInputWrong = true;
                while(isInputWrong)
                {
                    string input = Console.ReadLine();
                    
                    Console.SetCursorPosition(0, 10);   // 순서 안내문 위치로 이동 

                    switch (input)
                    {
                        case "1":
                            if (one != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                one = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "2":
                            if (two != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                two = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "3":
                            if (three != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                three = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "4":
                            if (four != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                four = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "5":
                            if (five != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                five = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "6":
                            if (six != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                six = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "7":
                            if (seven != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                seven = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "8":
                            if (eight != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                eight = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "9":
                            if (nine != null)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                                input = null;
                            }
                            else
                            {
                                PaintShape(shape, input);
                                nine = shape;
                                isInputWrong = false;
                            }
                            break;
                        default:
                            Console.WriteLine("1~9 사이의 번호로 다시 입력하세요:                 ");
                            WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                            Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            input = null;
                            break;
                    }

                }

                if (one == shape && two == shape && three == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (four == shape && five == shape && six == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (seven == shape && eight == shape && nine == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (one == shape && four == shape && seven == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (two == shape && five == shape && eight == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (three == shape && six == shape && nine == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (one == shape && five == shape && nine == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else if (three == shape && five == shape && seven == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    isThereWinner = true;
                    break;
                }
                else
                {

                }

            }

            if (isThereWinner == false)
            {
                Console.WriteLine("무승부입니다.                              \n다음 게임을 시작하시겠습니까?");
            }
            else
            {

            }
            

        }
    }
}
    
