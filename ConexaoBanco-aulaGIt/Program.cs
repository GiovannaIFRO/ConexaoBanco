

try //tratar as exeções evitando erros
{
    Console.Write("Informe o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Informe o primeiro valor: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Não é permitido a divisão por zero " + ex.Message);
}
catch(InvalidCastException ex)
{
    Console.WriteLine($"conversão de string para a  letra não é permitida {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("Algo de errado não está certo! " + ex.Message);
}
Console.ReadKey();
