public class User
{
    private readonly IUserInput _input;
    private readonly IOutput _output;

    public User(IUserInput input, IOutput output)
    {
        _input = input;
        _output = output;
    }

    public int MakeGuess()
    {
        _output.Print("Введите ваше предположение: ");
        return _input.GetInput();
    }
}