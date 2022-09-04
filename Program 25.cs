// See https://aka.ms/new-console-template for more information
double Res()
{
Console.WriteLine("Ведите целое число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите целое число B");
int B = Convert.ToInt32(Console.ReadLine());
int AB =1;
for (int i =1; i<=B; i++)
{
    AB=AB *A;
}
return AB;
}
Console.WriteLine (Res());

