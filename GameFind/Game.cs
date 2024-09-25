public class Game
{
    private readonly User _user;
    private readonly IOutput _output;
    private readonly IRandomNumberGenerator _randomNumberGenerator;
    private readonly GameSettings _settings;
    private int _targetNumber;

    public Game(User user, IOutput output, IRandomNumberGenerator randomNumberGenerator, GameSettings settings)
    {
        _user = user;
        _output = output;
        _randomNumberGenerator = randomNumberGenerator;
        _settings = settings;
        _targetNumber = _randomNumberGenerator.Generate(_settings.MinNumber, _settings.MaxNumber);
    }

    public void Play()
    {
        bool isGuessed = false;

        _output.Print($"Угадайте число от {_settings.MinNumber} до {_settings.MaxNumber}");

        while (!isGuessed)
        {
            int guess = _user.MakeGuess();

            if (guess < _targetNumber)
            {
                _output.Print("Загаданное число больше.");
            }
            else if (guess > _targetNumber)
            {
                _output.Print("Загаданное число меньше.");
            }
            else
            {
                _output.Print("Поздравляем, вы угадали!");
                isGuessed = true;
            }
        }
    }
}