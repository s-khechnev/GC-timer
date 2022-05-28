
internal class MyClass
{
    public static event Action<int>? OnDisposing;
    public static int count = 0;
    public long MyProperty1 { get; set; }
    public long MyProperty2 { get; set; }
    public long MyProperty3 { get; set; }
    public long MyProperty4 { get; set; }
    public long MyProperty5 { get; set; }
    public long MyProperty6 { get; set; }
    public long MyProperty7 { get; set; }
    public long MyProperty8 { get; set; }
    public long MyProperty9 { get; set; }

    public MyClass()
    {
        count++;
    }

    ~MyClass()
    {
        OnDisposing?.Invoke(count);
    }
    
}