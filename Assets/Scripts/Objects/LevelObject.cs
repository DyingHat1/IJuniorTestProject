using UnityEngine;

public abstract class LevelObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            OnContactPlayer(player);
        }
        else if(collision.TryGetComponent(out ObjectsStopper stopper))
        {
            gameObject.SetActive(false);
        }
    }

    protected abstract void OnContactPlayer (Player player);
}
