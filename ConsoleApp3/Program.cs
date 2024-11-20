char[] arr = { 'a', 'b', 'c', 'x', 'a', 'b', 'c', 'y', 'a', 'b', 'c', 'z' };
string str = new string(arr);
string searchPattern = "abc";
int count = 0;
int index = 0;
while ((index = str.IndexOf(searchPattern, index)) != -1)
{
    count++;
    index += searchPattern.Length;
}
Console.WriteLine($"Количество вхождений 'abc': {count}");
 