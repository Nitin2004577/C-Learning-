byte b = 255;
short s = 32767;
int i = 12345;
long l = 14567876L;
float f = 3.14f;
double d = 4.5678;
decimal deci = 3.56446545597m;
char c = 'S';
bool isCheck = true;

//convert integer 42 to string
int num = 42;

string numStr = num.ToString();

string dStr = "3.14";

double numDouble = Convert.ToDouble(dStr);

Console.WriteLine($"byte: {b}");
Console.WriteLine($"short: {s}");
Console.WriteLine($"int: {i}");
Console.WriteLine($"long: {l}");
Console.WriteLine($"float: {f}");
Console.WriteLine($"double: {d}");
Console.WriteLine($"decimal: {deci}");
Console.WriteLine($"char: {c}");
Console.WriteLine($"bool: {isCheck}");
Console.WriteLine($"Converted int (42) to string: {numStr}");
Console.WriteLine($"Converted string ('3.14') to double: {numDouble}");