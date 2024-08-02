using Calculator;
using System;
using System.Linq;

Prompts.PrintWelcomeMenu();
Prompts.PrintOptions();

bool ifLoop = false;
float LastAns = 0f;
do {
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();
    if (OptionChoice == "ESC"){
        break;
    }

    if (OptionChoice == "#") {
        ifLoop = true;
        continue;
    }

    if (OptionChoice == "*") {
        Console.WriteLine($"Last answer is {LastAns}");
        continue;
    }

    Console.WriteLine("Enter number 1: ");
    string? Number1 = Console.ReadLine();
    float Number1Converted = float.Parse(Number1);

    float Number2Converted = 0f;
    string[] binaryOptions = { "1", "2", "3", "4", "6", "7", "12", "13" };
    if (binaryOptions.Contains(OptionChoice)) {
        Console.WriteLine("Enter number 2: ");
        string? Number2 = Console.ReadLine();
        Number2Converted = float.Parse(Number2);
    }

    float Number3Converted = 0f;
    string[] tripleOptions = { "13" };
    if (tripleOptions.Contains(OptionChoice)) {
        Console.WriteLine("Enter number 3: ");
        string? Number3 = Console.ReadLine();
        Number3Converted = float.Parse(Number3);
    }
    switch(OptionChoice){
        case "1":
            float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
            LastAns = Sum;
            break;
        case "2":
            float Subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} - {Number2Converted} = {Subtract}");
            LastAns = Subtract;
            break;
        case "3":
            float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
            LastAns = Product;
            break;
        case "4":
            float Division = Evaluator.Eval("/", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} / {Number2Converted} = {Division}");
            LastAns = Division;
            break;
        case "5":
            float Factorial = Evaluator.Eval("factorial", Number1Converted);
            Console.WriteLine($"factorial{Number1Converted} = {Factorial}");
            LastAns = Factorial;
            break;
        case "6":
            float Idempotence = Evaluator.Eval("^", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted}'s Idempotence of {Number2Converted} = {Idempotence}");
            LastAns = Idempotence;
            break;
        case "7":
            float Logarithmic = Evaluator.Eval("log", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted}'s logarithmic {Number2Converted} = {Logarithmic}");
            LastAns = Logarithmic;
            break;
        case "8":
            float Sine = Evaluator.Eval("sin", Number1Converted);
            Console.WriteLine($"Sine{Number1Converted} = {Sine}");
            LastAns = Sine;
            break;
        case "9":
            float Cosine = Evaluator.Eval("cos", Number1Converted);
            Console.WriteLine($"Cosine{Number1Converted} = {Cosine}");
            LastAns = Cosine;
            break;
        case "10":
            float Tangent = Evaluator.Eval("tan", Number1Converted);
            Console.WriteLine($"Tangent{Number1Converted} = {Tangent}");
            LastAns = Tangent;
            break;
        case "11":
            float Cotangent = Evaluator.Eval("cot", Number1Converted);
            Console.WriteLine($"Cotangent{Number1Converted} = {Cotangent}");
            LastAns = Cotangent;
            break;
        case "12":
            float RectangleArea = Evaluator.Eval("rect", Number1Converted, Number2Converted);
            Console.WriteLine($"RectangleArea of{Number1Converted},{Number2Converted} = {RectangleArea}");
            LastAns = RectangleArea;
            break;
        case "13":
            float RectangleCircumference = Evaluator.Eval("rect_c", Number1Converted, Number2Converted, Number3Converted);
            Console.WriteLine($"RectangleCircumference of {Number1Converted}, {Number2Converted}, {Number3Converted} = {RectangleCircumference}");
            LastAns = RectangleCircumference;
            break;
        case "14":
            float CircleArea = Evaluator.Eval("circle_a", Number1Converted);
            Console.WriteLine($"CircleArea of {Number1Converted} = {CircleArea}");
            LastAns = CircleArea;
            break;
        case "15":
            float CircleCircumference = Evaluator.Eval("circle_c", Number1Converted);
            Console.WriteLine($"CircleCircumference of {Number1Converted} = {CircleCircumference}");
            LastAns = CircleCircumference;
            break;
        default:
            throw new Exception("unimplemented");
    }
}while (ifLoop);