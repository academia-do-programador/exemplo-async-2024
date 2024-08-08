namespace ExemploAsync.ConsoleApp;

public class ClasseTestes
{
    public string ExecutarTimeoutEmSegundos(int segundos)
    {
        Thread.Sleep(TimeSpan.FromSeconds(segundos));

        return $"Timeout de {segundos} segundo(s)";
    }
    
    public Task<string> ExecutarTimeoutEmSegundosAsync(int segundos)
    {
        return Task.Run(() =>
        {
            Thread.Sleep(TimeSpan.FromSeconds(segundos));

            return $"Timeout de {segundos} segundo(s)";
        });
    }
}