using NUnit.Framework;

namespace QuadraticEquation.Tests
{

    [TestFixture]
    [Author("maciej.zak@student.wsb.edu.pl")]
    [Category("QuadraticEquations")]
    public class SquareEquationCalculatorTests
    {
        [Test]
        [TestCase(1, 2, 3, 0)]
        [TestCase(-3, 1, -5, 0)]
        [TestCase(2, 0, 27, 0)]
        [TestCase(1, -18, 106, 0)]
        [TestCase(6, -120, 816, 0)]
        [TestCase(8, 160, 1600, 0)]
        [Description("This test proff counts of roots for diffrent cases")]
        public void CalculateNumberOfRoots_ValidValues_ExpectedZeroRoots(double a, double b, double c, int expectedRootsCount)
        {
            var q = new QuadraticEquationCalculation();
            var result = q.CalculateNumberOfRoots(a, b, c);
            Assert.AreEqual(expectedRootsCount, result);
        }

        [Test]
        [TestCase(1, 2, 1, 1)]
        [TestCase(1, -2, 1, 1)]
        [Description("This test proff counts of roots for diffrent cases")]
        public void CalculateNumberOfRoots_ValidValues_ExpectedOneRoot(double a, double b, double c, int expectedRootsCount)
        {
            var q = new QuadraticEquationCalculation();
            var result = q.CalculateNumberOfRoots(a, b, c);
            Assert.That(result, Is.EqualTo(expectedRootsCount));
        }

        [Test]
        [TestCase(2, 7, 6, 2)]
        [TestCase(1, -4, 3, 2)]
        [TestCase(1, 0, -4, 2)]
        [TestCase(6, 60, 126, 2)]
        [TestCase(7, -21, -28, 2)]
        [TestCase(8, 32, -96, 2)]
        [TestCase(1, 1, -72, 2)]
        [TestCase(5, -20, 0, 2)]
        [TestCase(0.12, -10.33, 0.66, 2)]
        [Description("This test proff counts of roots for diffrent cases")]
        public void CalculateNumberOfRoots_ValidValues_ExpectedTwoRoots(double a, double b, double c, int expectedRootsCount)
        {
            var q = new QuadraticEquationCalculation();
            var result = q.CalculateNumberOfRoots(a, b, c);
            Assert.Greater(result, 1);
        }

        [Test]
        [TestCase(2, 0, 27, 0)]
        [TestCase(1, -18, 106, 0)]
        [TestCase(6, -120, 816, 0)]
        [TestCase(1, 2, 1, 1)]
        [TestCase(1, -2, 1, 1)]
        [Description("This test proff counts of roots for diffrent cases")]
        public void CalculateNumberOfRoots_ValidValues_ExpectedLessOrEqualOneRoot(double a, double b, double c, int expectedRootsCount)
        {
            var q = new QuadraticEquationCalculation();
            var result = q.CalculateNumberOfRoots(a, b, c);
            Assert.LessOrEqual(result, 1);
        }

    }

    public class P
    {
        public static void Main() { }
    }
}


