namespace Observer.Tests;

public sealed class ConsoleOutputFixture : IDisposable
{
    private readonly StringWriter _stringWriter;
    private readonly TextWriter _originalOutput;
    private bool _disposed;

    public ConsoleOutputFixture()
    {
        _stringWriter = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_stringWriter);
    }

    public string GetOutput() => _stringWriter.ToString();

    public void Dispose()
    {
        if (_disposed) return;

        Console.SetOut(_originalOutput);
        _stringWriter.Dispose();
        _disposed = true;
    }
}
