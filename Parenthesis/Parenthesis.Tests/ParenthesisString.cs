namespace Parenthesis.Tests
{
    internal class ParenthesisString
    {
        private string value;

        public ParenthesisString(string value)
        {
            this.value = value;
        }

        internal bool IsValid()
        {
            if ((this.value.Contains("(") || this.value.Contains(")")) &&
                (!this.value.Contains("(") || !this.value.Contains(")")))
                return false;
            return true;
        }
    }
}