using System;
using System.Text.RegularExpressions;

namespace IGESParser
{
    class ParsedLine
    {
        private char type;
        private int lineNumber;
        private string content;
        public ParsedLine(string line)
        {
            type = line[72];
            content = line.Substring(0, 72);
            var restOfLine = line.Substring(72, 9);
            lineNumber = Convert.ToInt32(Regex.Split(restOfLine, @"(\s+)")[2]);
            Console.WriteLine(type + " " + lineNumber + " " + content);
        }

        public char GetLineType()
        {
            return type;
        }

        public string GetContent()
        {
            return content;
        }
    }
}
