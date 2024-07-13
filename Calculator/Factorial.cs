namespace Calculator{
    public class Factorial : IDegreeOperator{
        public static float Eval(float degree){
            // Convert the degree to an integer
            int n = (int)degree;
            
            // Check if the number is a non-negative integer
            if (degree < 0 || degree != n) {
                throw new ArgumentException("Factorial is only defined for non-negative integers.");
            }
            
            return (float)Calculate(n);
        }
        
        private static int Calculate(int n) {
            int result = 1;
            for (int i = 1; i <= n; i++) {
                result *= i;
            }
            return result;
        }
    }
}
