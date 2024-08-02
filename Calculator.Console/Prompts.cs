public class Prompts{
    public static void PrintWelcomeMenu() {
        Console.WriteLine(" **********************");
        Console.WriteLine("**   Welcome to the   **");
        Console.WriteLine("**   PROG8840 Calculator   **");
        Console.WriteLine(" **********************");
    }
    public static void PrintOptions() {
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Factorial");
        Console.WriteLine("6. Idempotence");
        Console.WriteLine("7. Logarithmic");
        Console.WriteLine("8. Sine");
        Console.WriteLine("9. Cosine");
        Console.WriteLine("10. Tangent");
        Console.WriteLine("11. Cotangent");
        Console.WriteLine("12. RectangleArea");
        Console.WriteLine("13. RectangleCircumference");
        Console.WriteLine("14. CircleArea");
        Console.WriteLine("15. CircleCircumference");

        Console.WriteLine("#. NoneStopMode");
        Console.WriteLine("*. LastAnswer");
        Console.WriteLine("ESC. Exit");
    }

}
