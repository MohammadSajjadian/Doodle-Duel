namespace DoodleDuel.Model;

public class Unit
{
    public Guid Id { get; set; }
    public UnitType Type { get; set; }
    public int Score { get; set; }
    public string Image { get; set; } = string.Empty;
    public double X { get; set; }
    public double Y { get; set; }
    public bool IsHit { get; private set; }

    public void Hit() => IsHit = true;
}
