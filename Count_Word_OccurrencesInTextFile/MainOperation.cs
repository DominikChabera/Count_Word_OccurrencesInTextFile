using System;
using System.Collections.Generic;
using System.Text;

namespace Count_Word_OccurrencesInTextFile
{
    public class MainOperation
    {
        private string _path;
        private string _text;
        private int _countLeanghtOfString;
        public MainOperation()
        {
            StartProgram();
        }

        private void StartProgram()
        {
            Console.WriteLine("The program calculates the number of characters in the * .txt file indicated by the user");
            Console.WriteLine();
            Console.WriteLine("Enter the path to the file whose contents I want to count :");
            Console.Write("Path: ");
            _path = Console.ReadLine();
            if (CheckPath())
            {
                ReadFile();
                _countLeanghtOfString = CountTextLeanght();
                Console.WriteLine($"The length of the text in the file is : {_countLeanghtOfString}");
            }
            else
                Console.WriteLine("Path can't by empty or null");

        }

        private void ReadFile()
        {
            try
            {
                _text = System.IO.File.ReadAllText(_path);
                _text = _text.Replace("\r\n", "").Replace(" ", "");
                _text.Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public bool CheckPath()
        {
            if (string.IsNullOrEmpty(_path))
                return false;
            else
                return true;
        }
        private int CountTextLeanght()
        {               
            try
            {
                int leanght = default;
                leanght = _text.Length;

                return leanght;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }

    }
}
