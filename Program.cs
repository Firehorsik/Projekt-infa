string name;
int maxHp = 100;
int hp;
int dmg;
int premia = 3;
double mnoznik = 1.6;
int attacks;

Console.Write("Podaj imię: ");
name = Console.ReadLine();

Console.Write("Podaj hp: ");
hp = int.Parse(Console.ReadLine());
bool alive = hp > 0;
double php = hp % maxHp;
bool haveFullHp = hp == maxHp;

Console.Write("Podstawowe obrażenia: ");
dmg = int.Parse(Console.ReadLine());
int lightAttack = dmg + premia;
int specialAttack = (int)(dmg * mnoznik);

Console.Write("Ile zwykłych ataków padło ");
attacks = int.Parse(Console.ReadLine());
int wholeDmg = (attacks * lightAttack) + specialAttack;

Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Imię: {name}");
Console.WriteLine($"Zdrowie: {hp}/{maxHp} ({php}%)");
Console.WriteLine($"Zwykły atak: {lightAttack}");
Console.WriteLine($"Atak specjalny: {specialAttack}");
Console.WriteLine($"Łączne zadane obrażenia: {wholeDmg}");
Console.WriteLine($"Żyje: {alive}");
Console.WriteLine($"Pełne zdrowie: {haveFullHp}");
Console.WriteLine("=====================================");