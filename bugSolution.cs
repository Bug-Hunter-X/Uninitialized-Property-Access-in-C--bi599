public class MyClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize property with default value

    public MyClass() // Or initialize in the constructor
    {
        MyProperty = 10; // Set a value in constructor
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; 
    }
}