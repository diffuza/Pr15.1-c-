string s1 = "Hello, World!";
// Поиск первого вхождения символа 'r' 
Console.WriteLine("Index of \'r\': " + s1.IndexOf('r')); // вывод на экран первого вхождения символа 'r' 
// Поиск первого вхождения символа 'l' начиная с позиции 4 
Console.WriteLine("Index of \'l\', start at 4: " + s1.IndexOf('l', 4)); // вывод на экран первого вхождения символа 'l ' 
// Поиск первого вхождения строки "World" 
Console.WriteLine("Index of \"World\": " + s1.IndexOf("World")); // вывод на экран первого вхождения строки 'world' 
// Поиск первого вхождения символа из набора ['o', 'd', ','] 
Console.WriteLine("Index of pos of any symbol in array: " + s1.IndexOfAny(new char[] { 'o', 'd', ',' })); // вывод на экран первого вхождения символа из набора 
// Поиск последнего вхождения символа 'l'  
Console.WriteLine("Last index of \'l\': " + s1.LastIndexOf('l')); // вывод на экран последнего вхождения символа 'l ' 
// Поиск последнего вхождения строки "or"
Console.WriteLine("Last index of \"or\": " + s1.LastIndexOf("or")); // вывод на экран последнего вхождения символа 'or'
// Поиск последнего вхождения символа из набора ['o', 'd', ',']
Console.WriteLine("Last index of pos of any symbol in array: " + s1.LastIndexOfAny(new char[] { 'o', 'd', ',' })); // вывод на экран последнего вхождения символа из набора 
Console.WriteLine("Contains \"World\"? " + s1.Contains("World")); // True Console.WriteLine("Starts with \"He\"? " + s1.StartsWith("He")); // True
Console.WriteLine("Ends with \"ld\"? " + s1.EndsWith("ld")); // False
Console.WriteLine("Substring start at pos 7: " + s1.Substring(7)); // World! 
Console.WriteLine("Substring start at pos 7 (4 chars): " + s1.Substring(7, 4));// вывод на экран строки с указанными изменениями // Worl
string t1 = "John"; string t2 = "John"; string t3 = "Mary";
Console.WriteLine("t1 == t2: " + (t1 == t2));// вывод на экран строки с указанными изменениями // True 
Console.WriteLine("t1 != t2: " + (t1 != t2));// вывод на экран строки с указанными изменениями // False 
Console.WriteLine("t1 == t3: " + (t1 == t3));// вывод на экран строки с указанными изменениями // False
Console.WriteLine("Equals method: t1.Equals(t2)" + t1.Equals(t2)); // True Console.WriteLine("Equals method: t1.Equals(t3)" + t1.Equals(t3)); // False
Console.WriteLine("Insert: " + "26".Insert(1, "[4]"));// вывод на экран строки с указанными изменениями // 2[4]6
Console.WriteLine("PadLeft: "); // вывод на экран строки с указанными изменениями
Console.WriteLine("some string".PadLeft(15));// вывод на экран строки с указанными изменениями // " some string"
Console.WriteLine("some string".PadLeft(15, '*'));// вывод на экран строки с указанными изменениями // "****some string"
Console.WriteLine("PadRight: "); // вывод на экран строки с указанными изменениями
Console.WriteLine("some string".PadRight(15));// вывод на экран строки с указанными изменениями // "some string " Console.WriteLine("some string".PadRight(15, '*')); // "some string****"
Console.WriteLine("Remove demo1: " + "Hello".Remove(2)); // вывод на экран строки с указанными изменениями
Console.WriteLine("Remove demo2: " + "Hello".Remove(2, 2)); // вывод на экран строки с указанными изменениями
Console.WriteLine("Hello, World!".Replace('!', '.'));// вывод на экран строки с указанными изменениями // Hello, World.
Console.WriteLine("Hello, World!".Replace("World", "John"));// вывод на экран строки с указанными изменениями // Hello, John!
Console.WriteLine("Hello, World!".ToUpper()); // вывод на экран строки с указанными изменениями // HELLO, WORLD! 
Console.WriteLine("Hello, World!".ToLower()); // вывод на экран строки с указанными изменениями // hello, world!
Console.WriteLine("Hello".Length);// вывод на экран строки с указанными данными // 5
foreach (var s in "1 2 3".Split(' '))
    Console.WriteLine(s);
foreach (var s in "1 2 3-4-5-6".Split(new char[] { ' ', '-' }))
    Console.WriteLine(s);