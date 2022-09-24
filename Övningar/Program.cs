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
for(int i = 2; i < 21; i++)
{
    if()
    {

    }
}
//Icke nummer = break point = skipp that nummbers turn
