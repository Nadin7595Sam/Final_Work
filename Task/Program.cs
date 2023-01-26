Console.Clear();
string[] WinxClub = {"Bloom", "Musa", "Flora"};  
Random rand = new Random();
int i = rand.Next(WinxClub.Length);

Console.WriteLine($"Фея {WinxClub[i]}");