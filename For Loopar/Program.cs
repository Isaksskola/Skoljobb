string[] kortlista = {"Hjärter 2", "Hjärter 3", "Hjärter 4", "Hjärter 5", "Hjärter 6", "Hjärter 7", "Hjärter 8", "Hjärter 9", "Hjärter 10", "Hjärter Knäkt", "Hjärter Dam", "Hjärter Kung", "Hjärter Ess",
"Spader 2", "Spader 3", "Spader 4", "Spader 5", "Spader 6", "Spader 7", "Spader 8", "Spader 9", "Spader 10", "Spader Knäkt", "Spader Dam", "Spader Kung", "Spader Ess",
"Ruter 2", "Ruter 3", "Ruter 4", "Ruter 5", "Ruter 6", "Ruter 7", "Ruter 8", "Ruter 9", "Ruter 10", "Ruter Knäkt", "Ruter Dam", "Ruter Kung", "Ruter Ess",
"Klöver 2", "Klöver 3", "Klöver 4", "Klöver 5", "Klöver 6", "Klöver 7", "Klöver 8", "Klöver 9", "Klöver 10", "Klöver Knäkt", "Klöver Dam", "Klöver Kung","Klöver Ess"};
List<string> cards = new List<string>();
cards.AddRange(kortlista);
List<string> hand = new List<string>();
Random rand = new Random();

string first = cards[rand.Next(cards.Count)];
cards.Remove(first);
hand.Add(first);
string second = cards[rand.Next(cards.Count)];
cards.Remove(second);
hand.Add(second);
string third = cards[rand.Next(cards.Count)];
cards.Remove(third);
hand.Add(third);
string fourth = cards[rand.Next(cards.Count)];
cards.Remove(fourth);
hand.Add(fourth);
string fifth = cards[rand.Next(cards.Count)];
cards.Remove(fifth);
hand.Add(fifth);
hand.ForEach(Console.WriteLine);


for (int byten = 0; byten < 2; byten++)
{

    if (byten < 2)
    {
        Console.WriteLine("Vill du byta några kort? ");
        var svar = Console.ReadLine();
        if (svar == "ja")
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vill du byta kort " + (i + 1) + "?");
                svar = Console.ReadLine();
                if (svar == "ja")
                {
                    hand[i] = cards[rand.Next(cards.Count)];
                    cards.Remove(hand[i]);
                }
            }


            hand.ForEach(Console.WriteLine);
        }
        else
        {
            byten = 2;
        }

    }

}
List<string> number = new List<string>()
{
    "Ess","2","3","4","5","6","7","8","9","10","Knäkt","Dam","Kung",
};
List<string> maxnum = new List<string>();
for (int i = 0; i < 13; i++)
{
    int count = 0;
    foreach (string s in hand)
    {
        if (s.EndsWith(number[i])) count++;
    }
    maxnum.Add(count.ToString());

}

int color = 0;

List<string> value = new List<string>()
{
    "Hjärter","Klöver","Spader","Ruter"
};
for (int i = 0; i < 4; i++)
{
    int count = 0;
    foreach (string s in hand)
    {
        if (s != null && s.StartsWith(value[i])) count++;
    }
    if (count == 5) color = 1;

}

int stege = 0;
for (int n = 0; n < 13; n++)
{
    if (maxnum[n] == "1")
    {
        stege = stege + 1;
    }
    else if (stege < 5) stege = 0;


}

int par = 0;
foreach (string s in maxnum)
{
    if (s != null && s.EndsWith("2")) par++;
}

int triss = 0;
foreach (string s in maxnum)
{
    if (s != null && s.EndsWith("3")) triss++;
}

int fyrtal = 0;
foreach (string s in maxnum)
{
    if (s != null && s.EndsWith("4")) fyrtal++;
}
if (fyrtal == 1) Console.WriteLine("Du har fyrtal");
if (par > 0)
{
    if (par == 1 && triss == 1) Console.WriteLine("du har kåk");
    else if (par == 2) Console.WriteLine("Du har två par");
    else if (par == 1) Console.WriteLine("Du har par");
}
else if (triss == 1) Console.WriteLine("Du har triss");

if (stege == 5 && color == 1) Console.WriteLine("WOW du fick färgstege");
else if (color == 1) Console.WriteLine("Du fick färg");
else if (stege == 5) Console.WriteLine("Du fick stege");

































































Console.WriteLine("popo");



