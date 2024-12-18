string folderPath = @"C:\Users\yarah\Documents\Visual Studio 2022\Data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Green Arrow", "Flash", "SuperGirl", "Legends of Tommorow" };
//string[] villains = { "Vandal Savage", "Demien Dark", "Joker", "Eobart Thone", "Lex Luthor" };


string[] weapon = { "magic powers", "gun", "sword", "fighting stick", "slipper" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Taday {villain} with {villainWeapon} tries to take over the world!");



static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
