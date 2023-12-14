public class Swimming : Activity
{
    private int _laps;


    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return ((_laps * 50.0 / 1000) / _length) * 60.0;
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }
}