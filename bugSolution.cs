public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Corrected code accessing a defined member
        Console.WriteLine(MyProperty); 
    }
}