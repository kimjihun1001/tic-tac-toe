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

        // 게임 실행 함수
        public static void PrintFirstMenuScreen()
        {
            Console.Clear();
            PaintTable();
            Console.WriteLine("게임을 시작합니다");

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

            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    shape = "O";
                }
                else
                {
                    shape = "X";
                }

                Console.WriteLine(shape + " 차례입니다. 원하는 칸의 번호를 입력하세요: ");

                bool isInputWrong = true;
                while (isInputWrong)
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
                            // int.Parse()와 달리 이렇게 switch 문으로 작성하면 "문자 입력 예외 처리" 가ㄴ
                            Console.WriteLine("1~9 사이의 숫채로 다시 입력하세요:                 ");
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


        // 3번 메뉴 화면 출력
        public static void PrintThirdMenuScreen()
        {
            Console.WriteLine("TTTTT   I    CCC   TTTTT     A     CCC   TTTTT   OO    EEEEE");
            Console.WriteLine("  T     I   CC       T      A A   CC       T    O  O   E    ");
            Console.WriteLine("  T     I    CCC     T     A   A   CCC     T     OO    EEEEE");
            Console.WriteLine("============================================================");
            Console.WriteLine("Tic-tac-toe (American English), noughts and crosses (Commonwe\n" +
                              "alth English), or Xs and Os (Irish English) is a paper-and-pen\n" +
                              "cil game for two players who take turns marking the spaces in a three-by-three grid with X or O. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row is the winner. It is a solved game, with a forced draw assuming best play from both players.");
        }

        // 칸 그리기 함수
        public static void PaintTable()
        {
            Console.WriteLine("1---2---3---+");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("4---5---6---+");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("7---8---9---+");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine();
            Console.WriteLine();
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

        public static void PrintSecondMenuScreen()
        {

        }


        // 메인 선택 화면 출력 
        public static void PrintMainScreen()
        {
            // 메인 선택 화면
            Console.Clear();
            
            Console.WriteLine("TTTTT   I    CCC   TTTTT     A     CCC   TTTTT   OO    EEEEE");
            Console.WriteLine("  T     I   CC       T      A A   CC       T    O  O   E    ");
            Console.WriteLine("  T     I    CCC     T     A   A   CCC     T     OO    EEEEE");
            Console.WriteLine("============================================================");
            Console.WriteLine("메뉴를 선택해주세요.");
            Console.WriteLine("1: 플레이어 대 플레이어");
            Console.WriteLine("2: 플레이어 대 컴퓨터");
            Console.WriteLine("3: 게임 설명");
            string mode = Console.ReadLine();

            // 메뉴 선택에 따라 
            try
            {
                switch (mode)
                {
                    case "1":
                        PrintFirstMenuScreen();
                        break;

                    case "2":
                        PrintSecondMenuScreen();
                        break;

                    case "3":
                        PrintThirdMenuScreen();
                        break;

                    default:
                        PrintMainScreen();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                PrintMainScreen();
            }
        }
 
        static void Main(string[] args)
        {
            
            // Clear the screen, then save the top and left coordinates.
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            PrintMainScreen();

            // Console.WriteLine();
            // 방금 커서가 있던 곳에서 다음줄로 넘어가게 하는 듯. 이걸 안해주면 아래처럼 커서 포지션 다시 정해야 함.
            // Console.SetCursorPosition(0, 6);




        }
    }
}
    
