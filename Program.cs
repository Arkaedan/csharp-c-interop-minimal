using System.Runtime.InteropServices;

[DllImport("lib")]
static extern int add(int a, int b);

Console.WriteLine(add(1, 2));
