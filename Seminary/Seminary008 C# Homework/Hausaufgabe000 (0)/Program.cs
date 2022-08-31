// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! I am a Tetris!");

//При повороте фигуры нет колизии
//Нет проигрыша при заполнении стакана
//Нет очков
//Нет скорости
string FigureSymbol = "██";
int PositionRow = 1;
int PositionCol = 5;


//------------------------------//

start: //Отладка Кнопка "Z"


void DrawBorder() //Боковая панель
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(0, 0);

    System.Console.Write(" ╔════════════════════╦═════════╗");
    for (int i = 1; i < 22; i++)
    {
        Console.SetCursorPosition(1, i);
        System.Console.Write("║");
        Console.SetCursorPosition(22, i);
        System.Console.Write("║");
        Console.SetCursorPosition(32, i);
        System.Console.Write("║");
    }
    Console.SetCursorPosition(0, 22);
    System.Console.Write(" ╚════════╡Esc exit╞══╩═════════╝");


    Write("keys", 18, 23);
    Write("  🡡 ", 20, 25);
    Write("🡠 🡣 🡢", 21, 25);

}



bool[,] RandomFigure()  //Выбор случайного блока
{
    bool[,] IBlok = new bool[,] // I blok   ####
            {

            {true}, {true}, {true}, {true }

            };

    bool[,] OBlok = new bool[,] // O blok   ##
            {                      //       ##
            {true, true},
            {true, true}
            };
    bool[,] TBlok = new bool[,] // T blok   #
            {                       //     ###
            {false, true, false},
            {true, true ,true }
            };

    bool[,] SBlok = new bool[,] // S blok    ##
           {                            //  ##
            {false, true, true},
            {true, true, false}
           };

    bool[,] ZBlok = new bool[,] //Z blok    ##
            {                            //  ##
            {true, true, false},
            {false, true, true}
            };

    bool[,] JBlok = new bool[,] //J blok       #
            {                            //  ###
            {false, false, true},
            {true, true, true}
            };

    bool[,] LBlok = new bool[,] //L blok     #
            {                            //  ###
            { true, false, false },
            { true, true, true }
            };

    int newFigure = new Random().Next(1, 8);
    if (newFigure == 1) { Console.ForegroundColor = ConsoleColor.Blue; return IBlok; }
    if (newFigure == 2) { Console.ForegroundColor = ConsoleColor.Green; return OBlok; }
    if (newFigure == 3) { Console.ForegroundColor = ConsoleColor.Red; return TBlok; }
    if (newFigure == 4) { Console.ForegroundColor = ConsoleColor.Yellow; return SBlok; }
    if (newFigure == 5) { Console.ForegroundColor = ConsoleColor.Cyan; return ZBlok; }
    if (newFigure == 6) { Console.ForegroundColor = ConsoleColor.Magenta; return JBlok; }
    Console.ForegroundColor = ConsoleColor.Gray;
    return LBlok;
}


bool[,] TetrisField = new bool[,] // Игровое поле
       {    {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true, false, false, false, false, false, false, false, false, false, false, true},
            {true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, true}
};


void Write(string text, int row, int col) //Писать по координате 
{
    Console.SetCursorPosition(col, row);
    Console.Write(text);
}


void DrawTetrisField(bool[,] array)  //Перерисовка игрового поля(Стирание следа за фигурой) 
{
    for (int row = 1; row < 22; row++)
    {
        if (row % 2 == 0)
        {
            Write($" · · · · · · · · · ·", row, 2);
        }
        else
        {
            Write($"                    ", row, 2);
        }
    }

    for (int row = 1; row < array.GetLength(0) - 1; row++)
    {
        for (int col = 1; col < array.GetLength(1) - 1; col++)
        {
            if (array[row, col])
            {
                Write($"{FigureSymbol}", row, col * 2);
            }
        }
    }
}


void DrawFigure(bool[,] FigureValue) //Рисование фигуры
{
    for (int row = 0; row < FigureValue.GetLength(0); row++)
    {
        for (int col = 0; col < FigureValue.GetLength(1); col++)
        {
            if (FigureValue[row, col])
            {
                Write($"{FigureSymbol}", row + PositionRow, col * 2 + PositionCol * 2);
            }
        }
        Console.SetCursorPosition(38, 22);

    }
}


void DrawNextFigure(bool[,] FigureValue) //Следующая фигура на игровом поле
{
    int PositionRow = 2;
    int PositionCol = 12;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Write("  ", i + PositionRow, j + PositionCol * 2);
        }
    }
    for (int row = 0; row < FigureValue.GetLength(0); row++)
    {
        for (int col = 0; col < FigureValue.GetLength(1); col++)
        {
            if (FigureValue[row, col])
            {
                Write($"{FigureSymbol}", row + PositionRow, col * 2 + PositionCol * 2);
            }
        }
    }
}


bool[,] RotateValueFigure(bool[,] FigureValue) //Поворот фигуры 
{
    var newFigure = new bool[FigureValue.GetLength(1), FigureValue.GetLength(0)];
    for (int row = 0; row < FigureValue.GetLength(0); row++)
    {
        for (int col = 0; col < FigureValue.GetLength(1); col++)
        {
            newFigure[col, FigureValue.GetLength(0) - row - 1] = FigureValue[row, col];
        }
    }
    return newFigure;
}


bool CollisionLeft(bool[,] FigureValue) //Столкновение слева
{
    {
        int i = FigureValue.GetLength(1) - FigureValue.GetLength(1);
        for (int row = 0; row < FigureValue.GetLength(0); row++)
            if (FigureValue[row, i])
            {
                if (TetrisField[PositionRow + row, PositionCol - 1] == FigureValue[row, i])
                {
                    return false;
                }
            }
        if (FigureValue.GetLength(1) > 1)
        {
            i = i + 1;
            for (int row = 0; row < FigureValue.GetLength(0); row++)
                if (FigureValue[row, i])
                {
                    if (TetrisField[PositionRow + row, PositionCol] == FigureValue[row, i])
                    {
                        return false;
                    }
                }
        }
        if (FigureValue.GetLength(1) > 2)
        {
            i = i + 1;
            for (int row = 0; row < FigureValue.GetLength(0); row++)
                if (FigureValue[row, i])
                {
                    if (TetrisField[PositionRow + row, PositionCol] == FigureValue[row, i])
                    {
                        return false;
                    }
                }
        }
        return true;
    }
}


bool CollisionRight(bool[,] FigureValue) //Столкновение справа
{
    int col = FigureValue.GetLength(1) - 1;
    for (int row = 0; row < FigureValue.GetLength(0); row++)
        if (FigureValue[row, col])
        {
            if (FigureValue[row, col] == TetrisField[PositionRow + row, PositionCol + FigureValue.GetLength(1)])
            {
                return false;
            }
        }
    if (FigureValue.GetLength(1) > 1)
    {
        col = col - 1;
        for (int row = 0; row < FigureValue.GetLength(0); row++)
            if (FigureValue[row, col])
            {
                if (FigureValue[row, col] == TetrisField[PositionRow + row, PositionCol - 1 + FigureValue.GetLength(1)])
                {
                    return false;
                }
            }
    }
    if (FigureValue.GetLength(1) > 2)
    {
        col = col - 1;
        for (int row = 0; row < FigureValue.GetLength(0); row++)

            if (FigureValue[row, col])
            {
                if (FigureValue[row, col] == TetrisField[PositionRow + row, PositionCol - 2 + FigureValue.GetLength(1)])
                {
                    return false;
                }
            }
    }
    return true;

}


bool CollisionDown(bool[,] FigureValue) //Столкновение снизу
{
    int row = FigureValue.GetLength(0) - 1;
    {
        for (int col = 0; col < FigureValue.GetLength(1); col++)
        {
            if (FigureValue[row, col])
            {
                if (TetrisField[PositionRow + row, PositionCol + col] == FigureValue[row, col])
                {
                    return false;
                }
            }
        }
    }
    if (FigureValue.GetLength(0) > 1)
    {
        row = row - 1;
        {
            for (int col = 0; col < FigureValue.GetLength(1); col++)
            {
                if (FigureValue[row, col])
                {
                    if (TetrisField[PositionRow + row, PositionCol + col] == FigureValue[row, col])
                    {
                        return false;
                    }
                }
            }
        }
    }
    if (FigureValue.GetLength(0) > 2)
    {
        row = row - 1;
        {
            for (int col = 0; col < FigureValue.GetLength(1); col++)
            {
                if (FigureValue[row, col])
                {
                    if (TetrisField[PositionRow + row, PositionCol + col] == FigureValue[row, col])
                    {
                        return false;
                    }
                }
            }
        }
    }
    return true;
}


void AddCurrentFigureToTetrisField(bool[,] FigureValue) // Пририсовать фигуру внутрь игрового поля
{
    for (int row = 0; row < FigureValue.GetLength(0); row++)
    {
        for (int col = 0; col < FigureValue.GetLength(1); col++)
        {
            if (FigureValue[row, col])
            {
                TetrisField[PositionRow + row - 1, PositionCol + col] = true;
                continue;
            }
        }
    }
}


void CheckForFullLines() // проверка на заполненную линию
{

    for (int row = 1; row < TetrisField.GetLength(0) - 1; row++)
    {
        bool rowIsFull = true;
        for (int col = 0; col < TetrisField.GetLength(1); col++)
        {
            if (!TetrisField[row, col])
            {
                rowIsFull = false;
                break;
            }
        }

        if (rowIsFull)
        {
            for (int rowToMove = row; rowToMove >= 1; rowToMove--)
            {
                for (int col = 0; col < TetrisField.GetLength(1); col++)
                {
                    TetrisField[rowToMove, col] = TetrisField[rowToMove - 1, col];
                }
            }

        }
    }

}


//-----------------------------------------------------------------------------//
//Основное действие игры 

Console.Clear();
bool[,] FigureValue = RandomFigure();
bool[,] nextFigure = RandomFigure();

DrawBorder();

while (true)        
{

    for (int i = 0; i < 16; i++) //Ожидание нажатия кнопки + 16 раз отрисовать фигуру
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }

            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (CollisionLeft(FigureValue))//проверка на столкновение
                {
                    PositionCol--;
                }
            }

            if (key.Key == ConsoleKey.RightArrow)
            {
                if (CollisionRight(FigureValue))//проверка на столкновение
                {
                    PositionCol++;
                }
            }

            if (key.Key == ConsoleKey.DownArrow)
            {
                if (CollisionDown(FigureValue))//проверка на столкновение
                {
                    PositionRow++;
                }
            }

            if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.UpArrow)
            {
                FigureValue = RotateValueFigure(FigureValue);
            }

            if (key.Key == ConsoleKey.Z)
            {
                goto start; //отладка
            }
            Thread.Sleep(5);
        }
        Thread.Sleep(20);                       //Speed
        DrawTetrisField(TetrisField); // 16 раз отрисовать поле
        DrawFigure(FigureValue);// 16 раз отрисовать фигуру
    }

    if (CollisionDown(FigureValue)) //проверка на столкновение спустить фигуру на 1 вниз
    {
        PositionRow++;
    }
    else
    {
        AddCurrentFigureToTetrisField(FigureValue); //Иначе пририсовал фигуру в игровое поле
        FigureValue = nextFigure; 
        PositionRow = 1;
        PositionCol = 5;
        CheckForFullLines();
        nextFigure = RandomFigure(); //Взял следующую фигуру
        DrawNextFigure(nextFigure);

    }
}// все по новой со строки 408
