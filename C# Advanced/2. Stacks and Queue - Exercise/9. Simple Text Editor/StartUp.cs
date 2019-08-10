using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class StartUp
    {
        static void Main()
        {
            Stack<string> dataEditor = new Stack<string>();
            int countOfOperations = int.Parse(Console.ReadLine());

            string text = string.Empty;
            for (int i = 0; i < countOfOperations; i++)
            {
                string[] inputCommands = Console.ReadLine().Split();
                string operation = inputCommands[0];

                if(operation == "1")
                {
                    text = text + inputCommands[1];
                    dataEditor.Push(text);
                }
                else if(operation == "2")
                {
                    int countEraseElements = int.Parse(inputCommands[1]);
                    if (text.Length >= countEraseElements)
                    {
                        text = text.Substring(0, text.Length - countEraseElements);
                        dataEditor.Push(text);
                    }                   
                }
                else if(operation == "3")
                {
                    int index = int.Parse(inputCommands[1]);
                    if (index - 1 >= 0 && index - 1 < text.Length)                        
                        Console.WriteLine(text[index - 1]);               
                }
                else if(operation == "4")
                {
                    if(dataEditor.Count > 0)
                        dataEditor.Pop();

                    text = dataEditor.Count > 0 ? dataEditor.Peek() : "";                     
                }
            }
        }
    }
}
