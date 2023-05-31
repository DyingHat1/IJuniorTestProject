using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * _speed);
    }
}
