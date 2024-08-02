namespace Calculator{
    public class Evaluator{
        public static float Eval(string Operator, params float[] Operands){
            if (Operands == null || Operands.Length == 0 || float.IsNaN(Operands[0]))
            {
                throw new ArgumentException("Invalid operand");
            }
            float result;
            switch(Operator){
                case "+":
                    result = Add.Eval(Operands[0], Operands[1]);
                    break;
                case "-":
                    result = Subtract.Eval(Operands[0], Operands[1]);
                    break;
                case "*":
                    result = Multiply.Eval(Operands[0], Operands[1]);
                    break;
                case "/":
                    result = Division.Eval(Operands[0], Operands[1]);
                    break;
                case "factorial":
                    result = Factorial.Eval(Operands[0]);
                    break;
                case "^":
                    result = Idempotence.Eval(Operands[0], Operands[1]);
                    break;
                case "log":
                    result = Logarithmic.Eval(Operands[0], Operands[1]);
                    break;
                case "sin":
                    result = Sine.Eval(Operands[0]);
                    break;
                case "cos":
                    result = Cosine.Eval(Operands[0]);
                    break;
                case "tan":
                    result = Tangent.Eval(Operands[0]);
                    break;
                case "cot":
                    result = Cotangent.Eval(Operands[0]);
                    break;
                case "rect":
                    result = RectangleArea.Eval(Operands[0], Operands[1]);
                    break;
                case "rect_c":
                    result = RectangleCircumference.Eval(Operands[0], Operands[1], Operands[2]);
                    break;
                case "circle_a":
                    result = CircleArea.Eval(Operands[0]);
                    break;
                case "circle_c":
                    result = CircleCircumference.Eval(Operands[0]);
                    break;
                default:
                    throw new Exception("unimplemented");
            }
            return result;
        }
    }
}