using Newtonsoft.Json;
using SFML.Window;

namespace Space_Invaders;

public class GameConfiguration
{
    public string Title { get; init; }
    public int Height { get; init; }
    public int Width { get; init; }
    public PlayerSettings PlayerSettings { get; init; }
    public float BulletSpeed { get; init; }
    public float BulletRadius { get; init; }
    public float EnemySpeed { get; init; }
    public float EnemySpawnCooldown { get; init; }

    public ScoreManagerSettings ScoreManagerSettings { get; init; }

    public GameConfiguration(string jsonPath)
    {
        string jsonString = File.ReadAllText(jsonPath);
        JsonConvert.PopulateObject(jsonString, this);
    }
}

public class PlayerSettings
{
    public float Speed { get; init; }
    public Keyboard.Key MovingLeftButton { get; init; }
    public Keyboard.Key MovingRightButton { get; init; }
    public Keyboard.Key MovingUpButton { get; init; }
    public Keyboard.Key MovingDownButton { get; init; }
    public Keyboard.Key ShootingButton { get; init; }
    public float ShootingCooldown { get; init; }
}