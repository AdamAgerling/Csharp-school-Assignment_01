

// String to test: 29535123p48723487597645723645

Console.WriteLine();
Console.WriteLine(" ------------------------------------------------------------------------------------------------------------");
Console.WriteLine(" |          The kind of string sequence the program is looking for: 29535123p48723487597645723645           |");
Console.WriteLine(" |             Copy the one above and try it, or make your own sequence and try it yourself! :)             |");
Console.WriteLine(" |                  The result of the sequence above should yield the sum: 5836428677242                    |");
Console.WriteLine(" ------------------------------------------------------------------------------------------------------------");
Console.WriteLine();

Console.Write("Input your string: ");

static void NumberFinderInAString()
    {
    var userInput = Console.ReadLine();
    Console.WriteLine();

    long totalSum = 0;

    for (int i = 0; i < userInput?.Length; i++)
        {
        for (int j = i + 1; j < userInput?.Length; j++)
            {
            string numberHighlighter = userInput.Substring(i, j - i + 1);
            if (IsANumber(numberHighlighter) && numberHighlighter[0] == numberHighlighter[numberHighlighter.Length - 1])
                {
                Console.Write(userInput.Substring(0, i));

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(numberHighlighter);

                Console.ResetColor();
                Console.WriteLine(userInput.Substring(j + 1));

                totalSum = totalSum + long.Parse(numberHighlighter);
                break;
                }
            }
        }
    Console.WriteLine();

    if (totalSum > 0)
        {
        Console.Write($"The total sum of all substrings added together is: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(totalSum);
        }
    else
        {
        Console.Write($"The program didnt find a number that coulde added together and therefor the result is: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(totalSum);
        }
    Console.ResetColor();
    Console.WriteLine();
    }

static bool IsANumber(string userInput)
    {
    foreach (char number in userInput)
        {
        if (!char.IsDigit(number))
            {
            return false;
            }
        }
    return true;
    }

NumberFinderInAString();
