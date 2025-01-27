using System;
using Xunit;
using QuadraticEquationSolver;

namespace QuadraticEquationSolver.Tests
{
    public class QuadraticSolverTests
    {
        [Theory]
        [InlineData(1, -3, 2, new[] { 2.0, 1.0 }, "Two real roots.")]
        [InlineData(1, 2, 1, new[] { -1.0 }, "One real root.")]
        [InlineData(1, 0, 1, new double[0], "No real roots.")]
        public void Solve_ValidQuadraticEquation_ReturnsExpected(double a, double b, double c, double[] expectedRoots, string expectedMessage)
        {
            // Act
            var (roots, message) = QuadraticSolver.Solve(a, b, c);

            // Assert
            Assert.Equal(expectedRoots.Length, roots.Length);
            Assert.Equal(expectedRoots, roots);
            Assert.Equal(expectedMessage, message);
        }

        [Fact]
        public void Solve_NotQuadraticEquation_ReturnsErrorMessage()
        {
            // Act
            var (roots, message) = QuadraticSolver.Solve(0, 2, 3);

            // Assert
            Assert.Empty(roots);
            Assert.Equal("Not a quadratic equation.", message);
        }
    }
}
