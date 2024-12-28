// See https://aka.ms/new-console-template for more information
Console.WriteLine("ENter your year of birth");
int age = Convert.ToInt32(Console.ReadLine());
if(age <= 15)
{
  Console.WriteLine("Not adult");
}
else
{
  Console.WriteLine("Adults");
}
