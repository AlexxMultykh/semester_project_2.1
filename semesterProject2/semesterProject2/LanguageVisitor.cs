using System.Globalization;
using static System.Console;
using semesterProject2.Content;

namespace semesterProject2;

public class LanguageVisitor : languageBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();

    public LanguageVisitor()
    {
        Variables["Write"] = new Func<object?[], object?>(Write);
        Variables["WriteLn"] = new Func<object?[], object?>(WriteLn);
    }

    public override object? VisitFunctionCall(languageParser.FunctionCallContext context)
    {
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if (!Variables.ContainsKey(name))
            throw new Exception($"Function {name} is not defined");

        if (Variables[name] is not Func<object?[], object?> func)
            throw new Exception($"Variable {name} is not a function");

        return func(args);
    }

    private static object? Write(object?[] args)
    {
        foreach (var arg in args)
            Console.Write(arg);

        WriteLine("");
        return null;
    }

    private static object? WriteLn(object?[] args)
    {
        foreach (var arg in args)
            WriteLine(arg);

        return null;
    }

    public override object? VisitAssignment(languageParser.AssignmentContext context)
    {
        var variableName = context.IDENTIFIER().GetText();
        var value = Visit(context.expression());

        Variables[variableName] = value;

        return null;
    }

    public override object? VisitIdentifierExpression(languageParser.IdentifierExpressionContext context)
    {
        string varName = context.IDENTIFIER().GetText();

        if (!Variables.ContainsKey(varName))
            throw new Exception($"Variable {varName} is not defined.");

        return Variables[varName];
    }

    public override object? VisitValue(languageParser.ValueContext context)
    {
        if (context.INTEGER() is { } i)
            return int.Parse(i.GetText());

        if (context.FLOAT() is { } f)
            return float.Parse(f.GetText(), CultureInfo.InvariantCulture.NumberFormat);  
        // I got an error
        // "input string was not in a correct format". So the thing after comma in brackets is a solution from the
        // internet.

        if (context.STRING() is { } s)
            return s.GetText()[1..^1];  // From the first to the last element

        if (context.BOOL() is { } b)
            return b.GetText() == "true";

        throw new NotImplementedException();
    }

    public override object? VisitMultiplicativeExpression(languageParser.MultiplicativeExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.mulOp().GetText();

        return op switch
        {
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            "%" => Modulo(left, right),
            _ => throw new NotImplementedException()
        };
    }

    public override object? VisitAdditiveExpression(languageParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.addOp().GetText();

        return op switch
        {
            "+" => Add(left, right),
            "-" => Subtract(left, right),
            _ => throw new NotImplementedException()
        };
    }

    public override object VisitComparisonExpression(languageParser.ComparisonExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.compOp().GetText();

        return op switch
        {
            "==" => IsEquals(left, right),
            "!=" => NotEquals(left, right),
            ">" => GreaterThan(left, right),
            ">=" => GreaterOrEqualThan(left, right),
            "<" => LessThan(left, right),
            "<=" => LessOrEqualThan(left, right),
            _ => throw new NotImplementedException()
        };
    }

    public override object? VisitBooleanExpression(languageParser.BooleanExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.boolOp().GetText();

        return op switch
        {
            "and" => And(left, right),
            "or" => Or(left, right),
            "xor" => Xor(left, right),
            _ => throw new NotImplementedException()
        };
    }

    public override object? VisitWhileLoop(languageParser.WhileLoopContext context)
    {
        Func<object?, bool> condition = IsTrue;

        if (condition(Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            } while (condition(Visit(context.expression())));
        }
        else
            Visit(context.elseIfBlock());

        return null;
    }

    public override object? VisitIfCondition(languageParser.IfConditionContext context)
    {
        Func<object?, bool> condition = IsTrue;

        if (condition(Visit(context.expression())))
        {
            Visit(context.block());
        }
        else
            Visit(context.elseIfBlock());

        return null;
    }

    private static object? Add(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l + r;

        if (left is float lF && right is float rF)
            return lF + rF;

        if (left is int lInt && right is float rFloat)
            return lInt + rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat + rInt;

        if (left is string || right is string)
            return $"{left}{right}";

        throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static object? Subtract(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l - r;

        if (left is float lF && right is float rF)
            return lF - rF;

        if (left is int lInt && right is float rFloat)
            return lInt - rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat - rInt;

        throw new Exception($"Cannot subtract values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static object? Multiply(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l * r;

        if (left is float lF && right is float rF)
            return lF * rF;

        if (left is int lInt && right is float rFloat)
            return lInt * rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat * rInt;

        throw new Exception($"Cannot multiply values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static object? Divide(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l / r;

        if (left is float lF && right is float rF)
            return lF / rF;

        if (left is int lInt && right is float rFloat)
            return lInt / rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat / rInt;

        throw new Exception($"Cannot divide values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static object? Modulo(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l % r;

        if (left is float lF && right is float rF)
            return lF % rF;

        if (left is int lInt && right is float rFloat)
            return lInt % rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat % rInt;

        throw new Exception($"Cannot module values of types {left?.GetType()} and {right?.GetType()}.");
    }
    
    private static bool LessThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l < r;

        if (left is float lF && right is float rF)
            return lF < rF;

        if (left is int lInt && right is float rFloat)
            return lInt < rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat < rInt;

        throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool GreaterThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l > r;

        if (left is float lF && right is float rF)
            return lF > rF;

        if (left is int lInt && right is float rFloat)
            return lInt > rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat > rInt;

        throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool LessOrEqualThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l <= r;

        if (left is float lF && right is float rF)
            return lF <= rF;

        if (left is int lInt && right is float rFloat)
            return lInt <= rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat <= rInt;

        throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool GreaterOrEqualThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l >= r;

        if (left is float lF && right is float rF)
            return lF >= rF;

        if (left is int lInt && right is float rFloat)
            return lInt >= rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat >= rInt;

        throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool IsEquals(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l == r;

        throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool NotEquals(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l != r;

        throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool And(object? left, object? right)
    {
        if (left is bool l && right is bool r)
            return l && r;

        throw new Exception($"Cannot logically AND values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool Or(object? left, object? right)
    {
        if (left is bool l && right is bool r)
            return l || r;

        throw new Exception($"Cannot logically AND values of types {left?.GetType()} and {right?.GetType()}.");
    }

    private static bool Xor(object? left, object? right)
    {
        if (left is bool l && right is bool r)
            return l ^ r;

        throw new Exception($"Cannot logically AND values of types {left?.GetType()} and {right?.GetType()}.");
    }
    
    private static bool IsTrue(object? value)
    {
     if (value is bool b)
         return b;

     throw new Exception("Value is not boolean.");
    }
}