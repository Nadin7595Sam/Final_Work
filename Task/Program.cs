Console.Clear();

var WinxClub = new string[] {"Bloom", "Musa", "Flora", "Techna", "Stella"};
Array.Resize(ref WinxClub, 2);
 
foreach (var fairy in WinxClub)
    Console.Write($"{fairy} ");
Console.WriteLine();