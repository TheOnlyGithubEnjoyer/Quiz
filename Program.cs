using System;

WriteCentered("QUIZ (PRESS ENTER TO START)");

Console.ReadLine();

static void WriteCentered(string text)
{
    // string text = "Hello world!";

    int numberOfSpaces = Console.WindowWidth / 2 - text.Length /2;

    int i = 0;
    while (i < numberOfSpaces)
    {
        i++;
        Console.Write(" ");

    }
    Console.WriteLine(text);
}

Console.WriteLine("First Question! What is the Capital of England? a) London b) Paris c) Rome");

string answer = Console.ReadLine();

answer = answer.ToLower();

int points = 0;

if (answer == "a" || answer == "london") {
    points = points + 1;
    Console.WriteLine("Yay you got it right! " + "Points = " + points + " (PRESS ENTER TO CONTINUE)");

}
else {
    Console.WriteLine("You got it wrong! " + "Points = " + points + " (PRESS ENTER TO CONTINUE)");
}

Console.ReadLine();

Console.WriteLine("Second Question! Which object is yellow? a) Stove b) Banana c) Palm tree");

string answer2 = Console.ReadLine();

answer2 = answer2.ToLower();

if (answer2 == "b" || answer2 == "banana") {
    points = points +1;
    Console.WriteLine("You got it right! " + "Points = " + points + " (PRESS ENTER TO CONTINUE)");

}
else {
    Console.WriteLine("Man how did you get that wrong? " + "Points = " + points + " (PRESS ENTER TO CONTINUE)");
}

Console.ReadLine();

Console.WriteLine("Third Question! What is the tallest building in the world? a) Empire state building b) Burj Khalifa c) Shanghai Tower");

string answer3 = Console.ReadLine();

answer3 = answer3.ToLower();

if (answer3 == "b")
{
    points = points +1;
    Console.WriteLine("Congrats! You got the right answer. " + "Points = " + points + " (PRESS ENTER TO CONTINUE)");
    }
else {
    Console.WriteLine("You got it wrong. " + "Points = " + points + " (PRESS ENTER TO CONTINUE)");
}
Console.ReadLine();

Console.WriteLine("Fourth and final Question! Points are TRIPLED! Which movie was made by Christopher Nolan? a) Interstellar b) Inception c) Memento");

string answer4 = Console.ReadLine();

answer4 = answer4.ToLower();

if (answer4 == "all three" || answer4 == "a, b and c" || answer4 == "abc") {
    points = points +3;
    Console.WriteLine("Good Job! You got the final question right " + "Final Points = " + points + " (PRESS ENTER TO CONTINUE)");

}
else {
    Console.WriteLine("Come on! You should know that it was a trick question. " + "Final Points = " + points + " / 6" + " (PRESS ENTER TO CONTINUE)");
}

Console.ReadLine();

