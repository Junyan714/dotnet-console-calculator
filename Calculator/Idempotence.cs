namespace Calculator {
    public class Idempotence : IBinaryOperator {
        public static float Eval(float lhs, float rhs) {
            return (float)Math.Pow((int)lhs, (int)rhs);
        }
    }
}
