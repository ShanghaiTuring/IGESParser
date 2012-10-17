namespace IGESParser
{
    class Parser
    {
        private readonly string[] lines;
        private ParsedLine[] parsedLines;
        private string globalInfo;
        public Parser(string igs)
        {
            lines = igs.Split('\n');
            parsedLines = new ParsedLine[lines.Length];
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > 0)
                {
                    parsedLines[i] = new ParsedLine(lines[i]);
                    ExtractGlobalInfo(parsedLines[i]);
                }
            } 
        }

        private void ExtractGlobalInfo(ParsedLine line)
        {
            if (line.GetLineType() == 'G')
            {
                globalInfo += line.GetContent();
            }
        }

        public int GetLineCount()
        {
            return lines.Length;
        }

        public string GetGlobalInfo()
        {
            return globalInfo;
        }
    }
}
