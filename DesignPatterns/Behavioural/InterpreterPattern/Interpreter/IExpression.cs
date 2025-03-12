using System;

namespace DesignPatterns.Behavioural.InterpreterPattern;

public interface IExpression
{
    public int Interpret(Context context);
}
