

try
{
    Console.Write("Informe o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Informe o primeiro valor: ");
    int b = int.Parse(Console.ReadLine());
    int result = a / b;
    Console.WriteLine(result);

}catch (Exception ex)
{
    Console.WriteLine("ALgo de errado não está certo!");
}
Console.ReadKey();
