// See https://aka.ms/new-console-template for more information
/*uvod*/
/* Console.WriteLine("Hello, World!");
int cislo = -13+22;
double desetinne_cislo = 308.1222;
string retezec = "ahoj svete";
char pismenko = 'A';
Console.WriteLine(10+222); */

/*prvni uloha*/
/*prohozeni cisel*/
/*int a = 10;   
int b = 20;
int c;
c = b;
b = a;
a = c;
Console.WriteLine(a);
Console.WriteLine(b);
Console.ReadKey();
*/

/* Druha uloha*/
/* prevod teploty
double prevod;
Console.WriteLine("Zadej teplotu ve stupnich celsia");
double teplota = double.Parse(Console.ReadLine());
prevod = ((1.8 * teplota) + 32);
Console.WriteLine(prevod);
Console.ReadKey();
*/

/* podminky - uvod */
/*int a = 100;
int b = 33;
bool a_vetsi = a > b;
if (a>b)
{
    Console.WriteLine("a je vetsi nez b");
}
else
{
    Console.WriteLine("b je vetsi nez a");
}

Console.ReadKey();
*/

/*podminky else if*/
/*treti uloha*/

/*
Console.WriteLine("Zadej tri cisla");

 double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
        Console.WriteLine("a je nejvetsi {0}", a);
    else Console.WriteLine("c je nejvetsi {1}", c);
}
else if (b > c)

{
    Console.WriteLine("b je nevetsi {1}", b);
}
else
{
    Console.WriteLine("c je nejvetsi {0}", c);
}
*/

/* switch uloha

Console.WriteLine("Zadej číslo");
int cislo= int.Parse(Console.ReadLine());
string vystup;

   if ((cislo == 6) || (cislo == 7))
{ 
        Console.WriteLine("Zadal jsi vikend");

switch (cislo)
{
    case 1:
        Console.WriteLine("Pondělí");
        break;
    case 2:
        Console.WriteLine("utery");
        break;
    case 3:
        Console.WriteLine("streda");
        break;
    case 4:
        Console.WriteLine("ctvrtek");
        break;
    case 5:
        Console.WriteLine("Patek");
        break;
 
    case 6: Console.WriteLine("Sobota");
            
        break;
    case 7: Console.WriteLine("nedele");
            
        break;
    default:
        vystup = "chyba";
        break;
    }
    Console.ReadKey();
    */
/*int opakovani = 10;
    for (int i = 0; i < opakovani;i++)
{
    Console.WriteLine(i);
}

int a = 10;
while (a >0)
{
    Console.WriteLine(a);
    a--;
}

*/

Console.WriteLine("Zadej cislo");
int cislo;
int vysledek = 0;
cislo=int.Parse(Console.ReadLine());
for( int i=0;i<cislo;i++)
{
    vysledek =+ i;
}
Console.WriteLine(vysledek);




