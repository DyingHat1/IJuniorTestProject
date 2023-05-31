public class Obstacle : LevelObject
{
    protected override void OnContactPlayer(Player player)
    {
        player.Die();
    }
}
