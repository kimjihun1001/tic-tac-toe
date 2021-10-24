using System;
//using static System.Console;

namespace TicTacToe
{
    class tictactoe
    {
        protected static int origRow;
        protected static int origCol;
        protected static string one = null;
        protected static string two = null;
        protected static string three = null;
        protected static string four = null;
        protected static string five = null;
        protected static string six = null;
        protected static string seven = null;
        protected static string eight = null;
        protected static string nine = null;

        protected static int scoreOfO = 0;
        protected static int scoreOfX = 0;
        protected static int scoreOfUser = 0;
        protected static int scoreOfComputer = 0;

        protected static bool doAgain = true;

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

        // 1번 메뉴 화면 출력 
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
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (four == shape && five == shape && six == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (seven == shape && eight == shape && nine == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (one == shape && four == shape && seven == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (two == shape && five == shape && eight == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (three == shape && six == shape && nine == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (one == shape && five == shape && nine == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
                    isThereWinner = true;
                    break;
                }
                else if (three == shape && five == shape && seven == shape)
                {
                    Console.WriteLine(shape + "의 승리입니다.                              ");
                    if (shape == "O")
                    {
                        scoreOfO++;
                    }
                    else
                    {
                        scoreOfX++;
                    }
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

        // 2번 메뉴 화면 출력 
        public static void PrintSecondMenuScreen()
        {
            Console.Clear();
            PaintTable();
            Console.WriteLine("게임을 시작합니다");

            string shape;

            one = "1";
            two = "2";
            three = "3";
            four = "4";
            five = "5";
            six = "6";
            seven = "7";
            eight = "8";
            nine = "9";

            bool isThereWinner = false;

            for (int i = 0; i < 5; i++)
            {
                shape = "O";

                Console.WriteLine(shape + " 차례입니다. 원하는 칸의 번호를 입력하세요: ");

                bool isInputWrong = true;
                while (isInputWrong)
                {
                    string input = Console.ReadLine();

                    Console.SetCursorPosition(0, 10);   // 순서 안내문 위치로 이동 

                    switch (input)
                    {
                        case "1":
                            if (one != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                one = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "2":
                            if (two != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                two = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "3":
                            if (three != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                three = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "4":
                            if (four != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                four = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "5":
                            if (five != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                five = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "6":
                            if (six != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                six = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "7":
                            if (seven != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                seven = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "8":
                            if (eight != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                eight = shape;
                                isInputWrong = false;
                            }
                            break;
                        case "9":
                            if (nine != input)
                            {
                                Console.WriteLine("이미 입력된 칸입니다. 다시 입력하세요:            ");
                                WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                                Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            }
                            else
                            {
                                PaintShape(shape, input);
                                nine = shape;
                                isInputWrong = false;
                            }
                            break;
                        default:
                            // int.Parse()와 달리 이렇게 switch 문으로 작성하면 "문자 입력 예외 처리" 가능 
                            Console.WriteLine("1~9 사이의 숫채로 다시 입력하세요:                 ");
                            WriteAt("  ", 0, 11);   // 숫자 입력받는 칸 지우기
                            Console.SetCursorPosition(0, 11);   // 숫자 입력받는 칸으로 커서 이동
                            break;
                    }

                }

                // 승패 판별 
                if (one == two && two == three)
                {
                    Console.WriteLine(one + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (four == five && five == six)
                {
                    Console.WriteLine(four + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (seven == eight && eight == nine)
                {
                    Console.WriteLine(seven + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (one == four && four == seven)
                {
                    Console.WriteLine(one + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (two == five && five == eight)
                {
                    Console.WriteLine(two + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (three == six && six == nine)
                {
                    Console.WriteLine(three + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (one == five && five == nine)
                {
                    Console.WriteLine(one + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else if (three == five && five == seven)
                {
                    Console.WriteLine(three + "의 승리입니다.                              ");
                    scoreOfUser++;
                    isThereWinner = true;
                    break;
                }
                else
                {

                }


                // X 차례

                // 2칸 확인 함수, 브레이크 
                // 컴퓨터 - 2칸 방어 / 3칸 완성
                bool isTwoChecked = true;
                while (isTwoChecked)
                {
                    //Console.WriteLine("2칸 체크중");
                    if (CheckTwoNum(one, two, three) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(four, five, six) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(seven, eight, nine) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(one, four, seven) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(two, five, eight) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(three, six, nine) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(one, five, nine) == true)
                    {
                        break;
                    }
                    else if (CheckTwoNum(three, five, seven) == true)
                    {
                        break;
                    }
                    // 한 칸 체크. 여기가 제일 어려운 듯 
                    // 모서리에 둘 경우에는 가운데에 둬야 함 
                    else if ((two == "O" || four == "O" || six == "O" || eight == "O") && five != "X" && five != "O")
                    {
                        ComputerPaintShape("X", "5");
                        break;
                    }

                    // 가운데가 O인데, 꼭짓점도 O일 경우, 나머지 꼭짓점을 막아야 함.
                    else if (five == "O" && (one == "O" || three == "O" || seven == "O" || nine == "O"))
                    {
                        ComputerPaintShape("X", FindBlank());
                        break;
                    }
                    // 꼭짓점에 둘 경우에는 옆에 둬야 함
                    // 1, 3에 두면 2
                    else if ((one == "O" || three == "O") && two != "X" && two != "O")
                    {
                        ComputerPaintShape("X", "2");
                        break;
                    }
                    // 7, 9에 두면 8
                    else if ((seven == "O" || nine == "O") && eight != "X" && eight != "O")
                    {
                        ComputerPaintShape("X", "8");
                        break;
                    }

                    // 가운데에 둘 경우에는 꼭짓점에 둬야 함
                    else if (five == "O" && one != "X")
                    {
                        ComputerPaintShape("X", "1");
                        break;
                    }
                    else
                    {
                        ComputerPaintShape("X", FindBlank());
                        break;
                    }

                }


                // X 차례 이후 승패 판별
                if (one == two && two == three)
                {
                    Console.WriteLine(one + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (four == five && five == six)
                {
                    Console.WriteLine(four + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (seven == eight && eight == nine)
                {
                    Console.WriteLine(seven + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (one == four && four == seven)
                {
                    Console.WriteLine(one + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (two == five && five == eight)
                {
                    Console.WriteLine(two + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (three == six && six == nine)
                {
                    Console.WriteLine(three + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (one == five && five == nine)
                {
                    Console.WriteLine(one + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else if (three == five && five == seven)
                {
                    Console.WriteLine(three + "의 승리입니다.                              ");
                    scoreOfComputer++;
                    isThereWinner = true;
                    break;
                }
                else
                {

                }

            }

            if (isThereWinner == false)
            {
                Console.WriteLine("무승부입니다.                                \n다음 게임을 시작하시겠습니까?");
            }
            else
            {

            }
        }

        // 3번 메뉴 화면 출력
        public static void PrintThirdMenuScreen()
        {
            Console.Clear();
            Console.WriteLine("TTTTT   I    CCC   TTTTT     A     CCC   TTTTT   OO    EEEEE");
            Console.WriteLine("  T     I   CC       T      A A   CC       T    O  O   E    ");
            Console.WriteLine("  T     I    CCC     T     A   A   CCC     T     OO    EEEEE");
            Console.WriteLine("============================================================");
            Console.WriteLine("Tic-tac-toe (American English), noughts and crosses (Commonw\n" +
                              "ealth English), or Xs and Os (Irish English) is a paper-and-\n" +
                              "pencil game for two players who take turns marking the space\n" +
                              "s in a three-by-three grid with X or O. The player who succe\n" +
                              "eds in placing three of their marks in a horizontal, vertica\n" +
                              "l, or diagonal row is the winner. It is a solved game, with \n" +
                              "a forced draw assuming best play from both players.");
            Console.WriteLine();
            Console.WriteLine("메인 화면으로 돌아가려면 Enter를 누르세요.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            // 오.. 이런 방법으로 다른 키 누르는 걸 무시할 수 있구나!!
            PrintMainScreen();
        }

        public static void PrintFourthMenuScreen()
        {
            Console.Clear();
            Console.WriteLine("1번 모드: 플레이어 대 플레이어");
            Console.WriteLine("O의 점수: " + scoreOfO);
            Console.WriteLine("O의 점수: " + scoreOfX);
            Console.WriteLine();
            Console.WriteLine("1번 모드: 플레이어 대 컴퓨터");
            Console.WriteLine("플레이어의 점수: " + scoreOfUser);
            Console.WriteLine("컴퓨터의 점수: " + scoreOfComputer);
            Console.WriteLine();
            Console.WriteLine("메인 화면으로 돌아가려면 Enter를 누르세요.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            PrintMainScreen();
            // 오.. 이런 방법으로 다른 키 누르는 걸 무시할 수 있구나!! 
        }

        // 2칸이 채워져있을 때 공격 혹은 방어. 노가다 힘들어... 
        public static bool CheckTwoNum(string first, string second, string third)
        {
            if (first == second && second != third && third != "O" && third != "X")
            {
                ComputerPaintShape("X", third);
                return true;
            }
            else if (first == third && third != second && second != "O" && second != "X")
            {
                ComputerPaintShape("X", second);
                return true;
            }
            else if (second == third && third != first && first != "O" && first != "X")
            {
                ComputerPaintShape("X", first);
                return true;
            }
            else
            {
                return false;
            }
        }


        // 표 그리기 함수
        public static void PaintTable()
        {
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine();
            Console.WriteLine();
        }

        // 모양 그리기 함수 - 컴퓨터용
        public static void ComputerPaintShape(string shape, string input)
        {
            switch (input)
            {
                case "1":
                    WriteAt(shape, 2, 1);
                    one = shape;
                    break;
                case "2":
                    WriteAt(shape, 6, 1);
                    two = shape;
                    break;
                case "3":
                    WriteAt(shape, 10, 1);
                    three = shape;
                    break;
                case "4":
                    WriteAt(shape, 2, 3);
                    four = shape;
                    break;
                case "5":
                    WriteAt(shape, 6, 3);
                    five = shape;
                    break;
                case "6":
                    WriteAt(shape, 10, 3);
                    six = shape;
                    break;
                case "7":
                    WriteAt(shape, 2, 5);
                    seven = shape;
                    break;
                case "8":
                    WriteAt(shape, 6, 5);
                    eight = shape;
                    break;
                case "9":
                    WriteAt(shape, 10, 5);
                    nine = shape;
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(0, 10);   // 순서 안내문 위치로 커서 이동 
        }
        


        // 모양 그리기 함수 - 사람용 
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

        // 빈칸있는지 확인하고 그리는 함수
        public static string FindBlank()
        {
            if (five == "5")
                return five;
            else if (one == "1")
                return one;
            else if (three == "3")
                return three;
            else if (seven == "7")
                return seven;
            else if (nine == "9")
                return nine;
            else if (two == "2")
                return two;
            else if (four == "4")
                return four;
            else if (six == "6")
                return six;
            else if (eight == "8")
                return eight;
            else
                return "0";
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
            Console.WriteLine("4: 점수 확인");
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

                    case "4":
                        PrintFourthMenuScreen();
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

            // 반복시키기 
            while(doAgain)
            {
                PrintMainScreen();
                Console.WriteLine("종료하시겠습니까? Y / N");
                string input = Console.ReadLine();
                while (true)
                {
                    if (input == "Y" || input == "y")
                    {
                        doAgain = false;
                        break;
                    }
                    else if (input == "N" || input == "n")
                    {
                        break;
                    }
                    else
                    {

                    }

                }

            }


            // Console.WriteLine();
            // 방금 커서가 있던 곳에서 다음줄로 넘어가게 하는 듯. 이걸 안해주면 아래처럼 커서 포지션 다시 정해야 함.
            // Console.SetCursorPosition(0, 6);


        }
    }
}
    
