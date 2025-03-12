using System;

namespace DesignPatterns.Structural.FacadePattern;

public class OrderRequest
{
    public string Name {get;} = "danny";
    public string CardNumber {get;} = "1234";
    public float Amount {get;} = 20.08f;
    public string Address {get;} = "123 Street";
    public string[] ItemsIds {get;} = {"a","b","f"};
}
