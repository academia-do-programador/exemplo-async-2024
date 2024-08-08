using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ExemploAsync.ConsoleApp;

class Program
{
    static async Task Main(string[] args)
    {
        ClasseTestes classe = new ClasseTestes();

        Stopwatch sw = new Stopwatch();
        
        sw.Start();
        
        var umSegundo = classe.ExecutarTimeoutEmSegundosAsync(1);
        var doisSegundos = classe.ExecutarTimeoutEmSegundosAsync(2);
        var tresSegundos = classe.ExecutarTimeoutEmSegundosAsync(3);
        
        sw.Stop();
        
        Console.WriteLine(await umSegundo);
        Console.WriteLine(await doisSegundos);
        Console.WriteLine(await tresSegundos);

        var tempoDecorrido = sw.Elapsed;

        Console.WriteLine($"\nO tempo decorrido nos processos foi de: {tempoDecorrido} segundo(s)");
        
        Console.ReadLine();
    } 
}