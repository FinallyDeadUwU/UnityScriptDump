public static class FlipflopBool
{
    //How to use it. Type: FlipflopBool.FlipFlop(your bool);
    
    public static bool FlipFlop(bool Value)
    {
        Value = !Value;
        return Value;
    }
}
