namespace Demo.Domain.Exceptions;
public class UnsupportedColourException : Exception
{
    public UnsupportedColourException(string code) : base($"Color \"{code}\" is unsupported.")
    {

    }
}
