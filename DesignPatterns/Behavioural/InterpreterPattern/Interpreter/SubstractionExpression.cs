using System;

namespace DesignPatterns.Behavioural.InterpreterPattern;

public class SubstractionExpression : IExpression
{

    private IExpression _left;
    private IExpression _right;

    public SubstractionExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }
    public int Interpret(Context context)
    {
        return _left.Interpret(context) - _right.Interpret(context);
    }
}
