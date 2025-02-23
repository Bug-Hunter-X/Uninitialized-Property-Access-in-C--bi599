public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned a value can lead to unpredictable behavior.
        int value = MyProperty * 2; // Bug: Potential use of unassigned local variable 'MyProperty'
    }
}