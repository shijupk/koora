using System;

namespace KooraLex
{
    /// <summary>
    /// Storage class for tokens
    /// </summary>
    public class Token
    {
        public TokenType Type { get; set; }
        public int Line { get; set; }
        public int Position { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            if (Type == TokenType.Integer || Type == TokenType.Identifier)
            {
                return String.Format("{0,-5}  {1,-5}   {2,-14}     {3}", Line, Position, Type.ToString(), Value);
            }
            else if (Type == TokenType.String)
            {
                return String.Format("{0,-5}  {1,-5}   {2,-14}     \"{3}\"", Line, Position, Type.ToString(), Value.Replace("\n", "\\n"));
            }
            return String.Format("{0,-5}  {1,-5}   {2,-14}", Line, Position, Type.ToString());
        }
    }
}
