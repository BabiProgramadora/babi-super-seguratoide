Console.WriteLine("Portero: ¿Qué edad tienes?");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Portero: ¿Cuanto dinero tienes?");
int dinero = Convert.ToInt32(Console.ReadLine());
if (dinero >= 20 && edad >= 18)
{
    Console.WriteLine("Bienvenido");
} else
{
    Console.WriteLine("A tu casa");
}
Console.ReadKey();