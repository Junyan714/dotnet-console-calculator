namespace Calculator{
    public class Cotangent: IDegreeOperator{
        public static float Eval(float degree){
            // Convert degrees to radians
            float radians = (float)(degree * Math.PI / 180.0);
            // Calculate the angle in radians
            return 1.0f / (float)Math.Tan(radians);
        }
        
    }
}