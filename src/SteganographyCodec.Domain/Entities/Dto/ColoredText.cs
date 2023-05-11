namespace SteganographyCodec.Domain.Entities.Dto
{
    public class ColoredText
    {
        public char[] Text { get; set; }
        public List<string> Colors { get; set; }
        public ColoredText()
        {
                
        }
        public ColoredText(char[] text, List<string> colors)
        {
            Text = text;
            Colors = colors;
        }
    }
}
