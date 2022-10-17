using Solver;

namespace SolverTests
{
    public class SolverTest
    {
        [Fact]
        public void OrdinaryEquation()
        {
            var a = 1;
            var b = -3;
            var c = 2;

            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.Equal(2, result.Length);
            Assert.Equal(2, result[0]);
            Assert.Equal(1, result[1]);
        }
    }
}