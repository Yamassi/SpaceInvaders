using SFML.Graphics;
using SFML.System;

namespace Space_Invaders;

public class Enemy
{
    public Vector2f Position => _sprite.Position;

    private readonly float _enemySpeed;
    private readonly Sprite _sprite;
    private AnimationManager _animationManager;
    private const float DEATH_ANIMATION_TIME = 0.2f;

    public Enemy(float enemySpeed, Texture texture, Vector2f spawnPosition, AnimationManager animationManager)
    {
        _animationManager = animationManager;
        _enemySpeed = enemySpeed;
        _sprite = new Sprite(texture);
        _sprite.Position = spawnPosition;
    }

    public void Draw(RenderWindow window)
    {
        window.Draw(_sprite);
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        _sprite.Position += new Vector2f(0, _enemySpeed);
    }

    public FloatRect GetGlobalBounds()
    {
        return _sprite.GetGlobalBounds();
    }

    public void PlayDeathAnimation()
    {
        var halfSpriteSize = (Vector2f)_sprite.Texture.Size / 2;
        var animationPosition = _sprite.Position - halfSpriteSize;
        var explosionAnimation =
            new SpriteAnimation(animationPosition, TextureManager.ExplosionAtlas, DEATH_ANIMATION_TIME);
        _animationManager.AddAnimation(explosionAnimation);
    }
}