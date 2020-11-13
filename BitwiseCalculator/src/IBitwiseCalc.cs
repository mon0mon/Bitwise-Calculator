namespace BitwiseCalculator
{
    public interface IBitwiseCalc
    {
        // string operation(int a, int b, int byteSize);
        string operation(string a, string b, int paddingSize);
    }
}