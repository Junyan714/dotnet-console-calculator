namespace Calculator{
    public class Division: IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            if (rhs == 0){
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return lhs / rhs;
        }
        
    }
}