namespace IGESParser
{
    //Directory Entry: Page 54
    //Parameter Data Section: Page 61

    abstract class Part
    {
        private string type;

        private double[] parameters;

        protected Part(ParsedLine[] directoryLines, ParsedLine[] parameterLines)
        {

        }
    }
}
