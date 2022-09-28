using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;
using static System.Console;

// *********** Övningsuppgifter ****************

//.1
//WriteLine("Insert first number");
//int NumberInput = Convert.ToInt32(ReadLine());
//WriteLine("Insert second number");
//int NumberInput_2 = Convert.ToInt32(ReadLine());
//WriteLine("The multiply result is:");
//WriteLine(NumberInput * NumberInput_2);

//.2
//WriteLine("Insert your first name");
//var FirstName = ReadLine();
//WriteLine("Insert your second name");
//var SecondName = ReadLine();
//WriteLine($"Welcom to my console {FirstName} {SecondName}");

//.3
//WriteLine("Insert your name");
//var input = ReadLine();
//string MyName = "Kappa";
//if(MyName.ToLower() == input.ToLower())
//{
//    WriteLine("Hej, du är personen jag tänkte på");
//}
//else
//{
//    WriteLine("Vem är du?");
//}

//.4
//WriteLine("Insert a number");
//double inputNr = Convert.ToDouble(ReadLine());
//WriteLine("The half of that number is:");
//WriteLine(inputNr / 2);

//.5
//WriteLine("Numbers from 20 to 30");
//for(int i = 20; i <= 30; i++)
//{
//    WriteLine(i);
//}

//.6
//for(int i = 0; i <= 30; i++)
//{
//    if(i % 2 == 0)
//    {
//        WriteLine(i);
//    }
//}

//.7
//for(int i = 0; i < 30; i++)
//{
//    if(i % 2 != 0)
//    {
//        WriteLine(i);
//    }
//}

//.8
//WriteLine("Insert a input");
//int InputNr = Convert.ToInt32(ReadLine());
//WriteLine("Im going to show you the table");
//for(int i = 0; i <= 10; i++)
//{
//    WriteLine(InputNr * i);
//}

//.9
//WriteLine("Insert Lenght");
//int L = Convert.ToInt32(ReadLine());
//WriteLine("Insert Height");
//int H = Convert.ToInt32(ReadLine());  
//for(int x = 0; x < H; x++)
//{
//    WriteLine(" ");
//    for (int i = 0; i < L; i++)
//    {
//        Write("X");
//    }
//}

//.10
//WriteLine("Insert Lenght");
//int L = Convert.ToInt32(ReadLine());
//WriteLine("Insert Height");
//int H = Convert.ToInt32(ReadLine());
//for(int x = 0; x < H; x++)
//{
//    WriteLine(" ");
//    for(int i = 0; i < L; i++)
//    {
//        if(i % 2 == 0)
//        {
//            Write("X");
//        }
//        else
//        {
//            Write("O");
//        }
//    }
//}

//.11
//WriteLine("Insert Lenght");
//int L = Convert.ToInt32(ReadLine());
//WriteLine("Insert Height");
//int H = Convert.ToInt32(ReadLine());
//for (int x = 0; x < H; x++)
//{
//    WriteLine(" ");
//    if(x % 2 == 0)
//    {
//        for(int i = 0; i < L; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Write("X");
//            }
//            else
//            {
//                Write("O");
//            }

//        }
//    }
//    else
//    {
//        for (int i = 0; i < L; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Write("O");
//            }
//            else
//            {
//                Write("X");
//            }

//        }

//    }
//}

//.12
//WriteLine("Insert Lenght");
//int L = Convert.ToInt32(ReadLine());
//WriteLine("Insert Height");
//int H = Convert.ToInt32(ReadLine());
//for (int x = 0; x < H; x++)
//{
//    WriteLine(" ");
//    for(int y = 0; y < L; y++)
//    {
//        if(x == 0)
//        {
//            Write("X");
//        }else if(y == 0)
//        {
//            Write("X");
//        }else if(y == L-1)
//        {
//            Write("X");
//        }else if(x == (H - 1))
//        {
//            Write("X");
//        }
//        else
//        {
//            Write(" ");
//        }
//    }
//}

//.13
//string nr = "";
//WriteLine(nr);
//for(int i = 1; i < 10; i++) {
//    nr += $"{i}";
//    WriteLine(nr);

//}

//.14
//for (int i = 1; i < 10; i++)
//{
//    string nr = "";
//    WriteLine(" ");
//    for(int x = 1; x < i+1; x++)
//    {
//        nr += $"{x}";
//        WriteLine(nr);
//    }
//}

//.15
//int SecretNumber = new Random().Next(1,101);
//bool FoundTheGuessedNumber = false;
//int TimesGuessed = 0;

//while(!FoundTheGuessedNumber)
//{
//    WriteLine("Guess a number");
//    int GuessedNr = new Random().Next(1, 101);
//    WriteLine($"Computer Guessed {GuessedNr}");
//    if(GuessedNr < SecretNumber)
//    {
//        WriteLine("You guessed to low");
//        Intructions();
//    }else if(GuessedNr > SecretNumber)
//    {
//        WriteLine("You guessed to high");
//        Intructions();
//    }else if(SecretNumber == GuessedNr)
//    {
//        FoundTheGuessedNumber = true;
//        WriteLine("Congratulations you found the number");
//        WriteLine($"You guessed ${TimesGuessed} times");
//        ReadKey();
//    }
//}

//void Intructions()
//{
//    TimesGuessed++;
//    WriteLine("Press any key to try again");
//}

//.16
//int sum = 0; 
//for(int i = 0; i < 1001; i++)
//{
//    sum+=i;
//}
//WriteLine(sum);

//.17
//List<int> AllPrimeNrs = new();
//bool notPrime = false;
//int j;

//for (int i = 2; AllPrimeNrs.Count < 21; i++)
//{
//    for (j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            notPrime = true;
//            break;
//        }
//    }

//    if (!notPrime)
//    {
//        AllPrimeNrs.Add(j);

//        Console.Write("{0} ", j);
//    }
//    else
//        notPrime = false;
//}

//.18 Fibonaccital
//List<int> previousResult = new() { 0, 1 };
//for(int i = 1; i < 30; i++)
//{
//    int result = previousResult[i] + previousResult[i + -1];
//    previousResult.Add(result);
//}
//foreach(int result in previousResult)
//{
//    Write(result + " ");
//}

//.19
//List<int> totalSum = new() { 0 };
//bool UserWritedNr = true;
//while (UserWritedNr)
//{
//    WriteLine("Write a number please");
//    int inputNr;
//    UserWritedNr = int.TryParse(ReadLine(), out inputNr);
//    totalSum.Add(totalSum.Last() + inputNr);
//    WriteLine("Total sum " + totalSum.Last());
//}
//WriteLine("Medelvärdet: " + (totalSum.Last()/ totalSum.Count));
//WriteLine("Thanks for playing");

//.20
//int WriteANumber()
//{
//    WriteLine("Write a number");
//    int inputNr = 0;
//    bool inputIsNr = int.TryParse(ReadLine(), out inputNr);
//    while (!inputIsNr)
//    {
//        WriteLine("Thats not a number try again");
//        inputIsNr = int.TryParse(ReadLine(), out inputNr);
//    }
//    return inputNr;
//}

//int FirstInputNumber = WriteANumber();

//WriteLine("Write the matematic symbol");
//string matSymbol = ReadLine();
//string[] ListOfMatSymbols = { "-", "+", "/", "*" };
//bool inputIsCorrectSymbol = ListOfMatSymbols.Contains(matSymbol);
//while (!inputIsCorrectSymbol)
//{
//    WriteLine("That not a correct matematic symbol try again");
//    matSymbol = ReadLine();
//    inputIsCorrectSymbol = ListOfMatSymbols.Contains(matSymbol);
//}

//int SecondInputNumber = WriteANumber();
//int result = 0;
//switch (matSymbol)
//{
//    case "-": result = FirstInputNumber - SecondInputNumber; break;
//    case "+": result = FirstInputNumber + SecondInputNumber; break;
//    case "*": result = FirstInputNumber * SecondInputNumber; break;
//    case "/": result = FirstInputNumber / SecondInputNumber; break;
//}
//WriteLine("The result of both of your numbers are: " + result);

//.21
//List<int> PreviousNrs = new() { 1 };
//for(int i = 0; i < 17; i++)
//{
//    PreviousNrs.Add(PreviousNrs[i] * 2);
//    WriteLine(PreviousNrs[i]);
//}

//.22
//string[] Tools = { "Sten", "Sax", "Påse" };

//WriteLine("Welcom to sten, sax and påse");
//WriteLine("Chose your tool");
//string userTool = ReadLine();
//string computerTool = Tools[new Random().Next(0, Tools.Length)];

//while (!Tools.Contains(userTool))
//{
//    WriteLine("That's not a valid tool chose either sten, sax or påse");
//    userTool = ReadLine();
//}

//WriteLine("You chosed: " + userTool);
//WriteLine("Computer chosed: " + computerTool);

//string CheckStrongestTool(string UserInput, string ComputerInput)
//{
//    string winnerOutput = "";
//    if(UserInput == ComputerInput)
//    {
//        winnerOutput = "Try again!";
//    }

//    if("Sten" == UserInput )
//    {
//        if(ComputerInput == "Påse")
//        {
//            winnerOutput = "Computer won";
//        }else if(ComputerInput == "Sax")
//        {
//            winnerOutput = "User won";
//        }
//    }
//    if("Sax" == UserInput)
//    {
//        if(ComputerInput == "Sten")
//        {
//            winnerOutput = "Computer won";
//        }else if(ComputerInput == "Påse")
//        {
//            winnerOutput = "User won";
//        }
//    }
//    if("Påse" == UserInput)
//    {
//        if(ComputerInput == "Sten")
//        {
//            winnerOutput = "User Won";
//        }else if(ComputerInput == "Sax")
//        {
//            winnerOutput = "Computer won";
//        }
//    }

//    return winnerOutput;
//}
//WriteLine(CheckStrongestTool(userTool, computerTool));

//.23.a
//for(int rows = 0; rows < 5; rows++)
//{
//    WriteLine(" ");
//    for(int cols = 0; cols < 9; cols++)
//    {
//        if(rows == cols)
//        {
//            Write("#");
//        }
//        else
//        {
//            Write("-");
//        }
//    }
//}

//.23.b
//for (int rows = 0; rows < 5; rows++)
//{
//    WriteLine(" ");
//    for (int cols = 0; cols < 9; cols++)
//    {
//        if (rows == cols || (rows + 4) == cols)
//        {
//            Write("#");
//        }
//        else
//        {
//            Write("-");
//        }
//    }
//}
//.23.c
//for (int rows = 0; rows < 5; rows++)
//{
//    WriteLine(" ");
//    for (int cols = 0; cols < 9; cols++)
//    {
//        if (rows == cols || (rows + 1) == cols)
//        {
//            Write("#");
//        }
//        else
//        {
//            Write("-");
//        }
//    }
//}
//23.d
//for (int rows = 0; rows < 5; rows++)
//{
//    WriteLine(" ");
//    for (int cols = 0; cols < 9; cols++)
//    {
//        if(rows == 3)
//        {
//            Write("#");
//        }
//        else
//        {
//            if(cols == 2 || cols == 5)
//            {
//                Write("#");
//            }
//            else
//            {
//                Write("-");
//            }
//        }
//    }
//}
//23.e
//int revers = 4;
//for (int rows = 0; rows < 4; rows++)
//{
//    WriteLine(" ");
//    for (int cols = 0; cols < 7; cols++)
//    {

//        if (rows == cols)
//        {
//            Write("#");
//        }
//        else if (revers == cols)
//        {
//            revers--;
//            Write(cols);
//        }
//        Write("-");
//    }
//}

//.24
//string HelloWorld = "Hello World";

//for(int i = HelloWorld.Length -1; i >= 0; i--)
//{
//    Write(HelloWorld[i]);
//}

//.25
//string HelloWorld = "Hello World";

//for (int i = 0; i < HelloWorld.Length; i++)
//{
//    if (HelloWorld[i] == 'o')
//    {
//        Write("X");
//    }
//    else
//    {
//        Write(HelloWorld[i]);
//    }
//}

//.26
//string HelloWorld = "Hello World";

//for (int i = 0; i < HelloWorld.Length; i++)
//{
//    if (i % 2 != 0)
//    {
//        Write("X");
//    }
//    else
//    {
//        Write(HelloWorld[i]);
//    }
//}

//.27
//string HelloWorld = "Hello World";

//for (int i = 0; i < HelloWorld.Length; i++)
//{

//    for(int x = 0; x <= i; x++)
//    {
//        Write(HelloWorld[x]);
//    }
//    WriteLine(" ");
//}

//.28
//WriteLine("Write a text");
//string userInput = ReadLine();

//int amountOfLetters = 0;
//WriteLine("How many letters would you like to see?");
//bool APL = int.TryParse(ReadLine(), out amountOfLetters);

//while (!APL)
//{
//    WriteLine("Thats not a number, try again!");
//    APL = int.TryParse(ReadLine(), out amountOfLetters);
//}

//for(int i = 0; i < amountOfLetters; i++)
//{
//    Write(userInput[i]);
//}

//.29
//WriteLine("Write a text");
//string userInput = ReadLine();
//WriteLine("Write a letter");
//string userLetter = ReadLine();

//while(userLetter.Length > 1)
//{
//    WriteLine("You can only write a letter!!!! try again");
//    userLetter = ReadLine();
//}
//for(int i=0; i < userInput.Length; i++)
//{
//    ForegroundColor = ConsoleColor.Gray;
//    if (userInput[i] == userLetter[0])
//    {
//        ForegroundColor = ConsoleColor.Red;
//    }
//    Write(userInput[i]);
//}

//.30
WriteLine("Write a text");
string userInput = ReadLine();
WriteLine($"Chose a number between : 1 and {userInput.Length}");
int userFirstNr = checkIfInt(ReadLine());
WriteLine($"Chose a second number between : 1 and {userInput.Length}");
int userSecondNr = checkIfInt(ReadLine());

int checkIfInt(string input)
{
    int output;
    bool isNr = int.TryParse(input, out output);
    while (!isNr || output > userInput.Length)
    {
        if(output > userInput.Length)
        {
            WriteLine("That higher number than the max, try again!");
        }
        else
        {
            WriteLine("Thats not a number try again");
        }
        isNr = int.TryParse(ReadLine(), out output);
    }
   
    return output;
}

for(int i = 0; i < userInput.Length; i++)
{
    if(i+1 >= userFirstNr && i+1 <= userSecondNr)
    {
        ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        ForegroundColor = ConsoleColor.Gray;
    }
    Write(userInput[i]);
}