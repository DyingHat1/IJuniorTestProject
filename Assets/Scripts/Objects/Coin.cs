public class Coin : LevelObject
{
    protected override void OnContactPlayer(Player player)
    {
        player.CollectCoin();
        gameObject.SetActive(false);
    }
}
