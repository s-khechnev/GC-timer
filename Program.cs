using System.Diagnostics;

int i = 0;
Stopwatch timer = new Stopwatch();
bool flag = false;
int n = 100000000;

MyClass.OnDisposing += MyClass_OnDisposing;


void MyClass_OnDisposing(int id)
{
    timer.Start();
    flag = true;

    MyClass.OnDisposing -= MyClass_OnDisposing;
}

for (i = 0; i < n; i++)
{
    MyClass item = new();
    if (flag)
    {
        timer.Stop();
        TimeSpan ts = timer.Elapsed;
        System.Console.WriteLine($"Elapsed Ticks: {timer.ElapsedTicks}");
        System.Console.WriteLine($"Elapsed Milliseconds: {timer.ElapsedMilliseconds}");

        flag = false;
        break;
    }
}
