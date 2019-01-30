using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (var reader = new StreamReader("../../../text.txt"))
        {
            int counter = 1;

            using (var writer = new StreamWriter("../../../output.txt"))
            {
                var line = reader.ReadLine();

                while(line !=null)
                {

                    int letterCount = 0;
                    int symbolsCount = 0;

                    if(counter !=1)
                    {
                        writer.WriteLine();
                    }

                    foreach (var @char in line)
                    {
                        if(char.IsLetter(@char))
                        {
                            letterCount++;
                        }
                        else if(char.IsPunctuation(@char))
                        {
                            symbolsCount++;
                        }
                    }

                    writer.Write($"Line {counter}: {line} ({letterCount}) ({symbolsCount})");

                    counter++;

                    line = reader.ReadLine();
                }
            }
        }
    }
}

