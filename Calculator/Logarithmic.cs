namespace Calculator{
    public class Logarithmic: IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            // Check for valid input
            if (lhs <= 0 || rhs <= 0) {
                throw new ArgumentException("Logarithms are only defined for positive numbers.");
            }
            // Use the change of base formula and cast the result to float
            return (float)(Math.Log(lhs) / Math.Log(rhs));
        }
        
    }
}