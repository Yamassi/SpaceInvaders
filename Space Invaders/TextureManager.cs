using SFML.Graphics;

namespace Space_Invaders;

public static class TextureManager
{
    private const string ASSETS_PATH = "/Users/yamassi/GameDev/Space Invaders/Assets";
    private const string BACKGROUND_TEXTURE_PATH = "/Backgrounds/gameBG.png";
    private const string PLAYER_TEXTURE_PATH = "/Ships/playerShip2_red.png";
    private const string ENEMY_TEXTURE_PATH = "/Enemies/enemyBlue1.png";
    private const string EXPLOSIONS_SPRITE_ATLAS_PATH = "/Explosions/explosionsAtlas.png";
    private const int EXPLOSIONS_SPRITE_ATLAS_COLUMNS = 4;
    private const int EXPLOSIONS_SPRITE_ATLAS_ROWS = 4;

    public static readonly Texture BackgroungTexture;
    public static readonly Texture PlayerTexture;
    public static readonly Texture EnemyTexture;
    public static readonly SpriteAtlas ExplosionAtlas;

    private static readonly SpriteAtlasSettings ExplosionAtlasSettings =
        new(ASSETS_PATH + EXPLOSIONS_SPRITE_ATLAS_PATH, 4, 4);

    static TextureManager()
    {
        BackgroungTexture = new Texture(ASSETS_PATH + BACKGROUND_TEXTURE_PATH);
        PlayerTexture = new Texture(ASSETS_PATH + PLAYER_TEXTURE_PATH);
        EnemyTexture = new Texture(ASSETS_PATH + ENEMY_TEXTURE_PATH);
        ExplosionAtlas = new SpriteAtlas(ExplosionAtlasSettings);
    }
}