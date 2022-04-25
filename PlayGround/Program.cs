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
double teplota;
double prevod;
Console.WriteLine("Zadej teplotu ve stupnich celsia");
teplota = int.Parse(Console.ReadLine());
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


Console.WriteLine("Zadej tri cisla");
double a;
double b;
double c;
a = int.Parse(Console.ReadLine());
b= int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
        Console.WriteLine("a je nejvetsi {0}", a);
    else Console.WriteLine("c je nejvetsi {2}", c);
}
else if (b > c)

{
    Console.WriteLine("b je nevetsi {1}", b);
}
else
{
    Console.WriteLine("c je nejvetsi {2}", c);
}



