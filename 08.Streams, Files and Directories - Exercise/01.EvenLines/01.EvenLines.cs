using System;
using System.IO;

class Program
{
    static void Main()
    {
        string specialSymbols = "-.,!?";
        int counter = 0;

        using (var reader = new StreamReader("../../../text.txt"))
        {
            using (var writer = new StreamWriter("../../../output.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 == 0)
                    {
                        if(counter !=0)
                        {
                            writer.WriteLine();
                        }
                        string changedLine = string.Empty;
                        foreach (var charr in line)
                        {
                            if (specialSymbols.Contains(charr))
                            {
                                changedLine += '@';
                            }

                            else
                            {
                                changedLine += charr;
                            }
                        }

                        string[] splitedLine = changedLine.Split();

                        Array.Reverse(splitedLine);

                        writer.Write(string.Join(" ", splitedLine));
                    }
                    counter++;
                }
            }
        }
    }
}

