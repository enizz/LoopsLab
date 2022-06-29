// example 1

//do
//{
//    Console.WriteLine("Hello, World!");
//    Console.WriteLine("Would you like to continue (y/n)?");
//} while (Console.ReadLine() != "n");

// example 2

//Console.WriteLine("Type a number");

//int x = int.Parse(Console.ReadLine());
//for (int i = x; i >=0; i--)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i <= x; i++)
//{
//    Console.WriteLine(i);
//}

// example 3

//bool wrongCode = true;

//while (wrongCode)
//{
//    Console.WriteLine("Please enter security code");
//    int code = int.Parse(Console.ReadLine());

//    if (code == 13579)
//    {
//        wrongCode = false;
//    }
//}

//Console.WriteLine("Successful code entry.");

// example 4

//bool wrongCode = true;
//int failedAttempts = 0;
//while (wrongCode)
//{
//    Console.WriteLine("Please enter security code");
//    int code = int.Parse(Console.ReadLine());

//    if (code == 13579)
//    {
//        wrongCode = false;
//    }
//    else
//    {
//        failedAttempts++;
//    }

//    if (failedAttempts == 5)
//    {
//        Console.WriteLine("Too many unsuccessful attempts");
//        break;
//    }
//}

//if (failedAttempts < 5)
//{
//Console.WriteLine("Successful code entry.");
//}

// example 5

bool wrongCode = true;
int failedAttempts = 0;
do
{
    Console.WriteLine("Please enter security code");
    int code = int.Parse(Console.ReadLine());

    if (code == 13579)
    {
        wrongCode = false;
    }
    else
    {
        failedAttempts++;
    }

    if (failedAttempts == 5)
    {
        Console.WriteLine("Too many unsuccessful attempts");
        break;
    }
}
while (wrongCode);

if (failedAttempts < 5)
{
    Console.WriteLine("Successful code entry.");
}