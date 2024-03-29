using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Parenthesis.Tests
{
    [TestClass]
    public class ParenthesisStringTest
    {
        [TestMethod]
        public void Should_return_true_when_string_does_not_contain_any_parenthesis()
        {
            ParenthesisString parenthesisString = new ParenthesisString("a");
            Check.That(parenthesisString.IsValid()).IsTrue();
        }

        [TestMethod]
        public void Should_return_false_when_string_contains_only_opening_parenthesis()
        {
            ParenthesisString parenthesisString = new ParenthesisString("(");
            Check.That(parenthesisString.IsValid()).IsFalse();
        }

        [TestMethod]
        public void Should_return_false_when_string_contains_only_closing_parenthesis()
        {
            ParenthesisString parenthesisString = new ParenthesisString(")");
            Check.That(parenthesisString.IsValid()).IsFalse();
        }

        [TestMethod]
        public void Should_return_true_when_string_contains_only_opening_and_closing_parenthesis_in_the_right_order()
        {
            ParenthesisString parenthesisString = new ParenthesisString("()");
            Check.That(parenthesisString.IsValid()).IsTrue();
        }
    }
}
