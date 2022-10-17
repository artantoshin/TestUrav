using Solver;

namespace SolverTests
{
    public class SolverTest
    {
        void TestEquation(double a, double b, double c, double[] expectedResult)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.Equal(expectedResult.Length, result.Length);
            
            for (int i = 0; i < result.Length; i++)
                Assert.Equal(expectedResult[i], result[i]);
        }

        [Fact]
        public void OrdinaryEquation()
        {
            var a = 1;
            var b = -3;
            var c = 2;

            TestEquation(a, b, c, new double[] {2,1});
        }

        [Fact]
        public void NegativeDiscriminant()
        {
            var a = 1;
            var b = 1;
            var c = 1;

            TestEquation(a, b, c, new double[0]);
        }
    }
}