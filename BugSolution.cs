public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Default value

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty);
    }
}