using DoodleDuel.Model;

namespace DoodleDuel.Services;

public class UnitService
{
    private readonly Random _random = new();

    private readonly Dictionary<UnitType, string[]> _unitImages = new()
    {
        [UnitType.Human] =
        [
            "/img/units/humans/human1.png",
            "/img/units/humans/human2.png",
            "/img/units/humans/human3.png",
            "/img/units/humans/human4.png",
        ],
        [UnitType.Alien] =
        [
            "/img/units/aliens/alien1.png",
            "/img/units/aliens/alien2.png",
            "/img/units/aliens/alien3.png",
            "/img/units/aliens/alien4.png",
        ],
        [UnitType.Tank] =
        [
            "/img/units/tanks/tank1.png",
            "/img/units/tanks/tank2.png",
            "/img/units/tanks/tank3.png",
            "/img/units/tanks/tank4.png",
        ],
    };

    public (List<Unit> PlayerUnits, List<Unit> OpponentUnits) CreateUnits(int count)
    {
        var initialUnits = new List<Unit>();
        for (int i = 0; i < count; i++)
        {
            initialUnits.Add(CreateRandomUnit());
        }

        var playerUnits = SetPositionAndId(initialUnits);
        var opponentUnits = SetPositionAndId(initialUnits);

        return (playerUnits, opponentUnits);
    }

    private Unit CreateRandomUnit()
    {
        var type = GetRandomType();

        return new Unit
        {
            Type = type,
            Score = GetScore(type),
            Image = GetRandomImage(type),
        };
    }

    private List<Unit> SetPositionAndId(List<Unit> initialUnits)
    {
        return [.. initialUnits.Select(u => new Unit
        {
            Id = Guid.NewGuid(),
            Type = u.Type,
            Score = u.Score,
            Image = u.Image,
            X = _random.Next(10, 90),
            Y = _random.Next(20, 90),
        })];
    }

    private UnitType GetRandomType()
    {
        var types = Enum.GetValues<UnitType>();

        return types[_random.Next(types.Length)];
    }

    private string GetRandomImage(UnitType type)
    {
        var images = _unitImages[type];

        return images[_random.Next(images.Length)];
    }

    private int GetScore(UnitType type)
    {
        return type switch
        {
            UnitType.Human => 100,
            UnitType.Alien => 200,
            UnitType.Tank => 350,
            _ => 0
        };
    }
}
