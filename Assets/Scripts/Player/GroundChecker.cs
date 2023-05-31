using UnityEngine;
using UnityEngine.Events;

public class GroundChecker : MonoBehaviour
{
    public event UnityAction Grounded;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Grounded?.Invoke();
    }
}
