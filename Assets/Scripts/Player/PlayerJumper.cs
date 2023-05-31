using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private float _jumpHeight;

    private const int ConstPhysicsValue = -2;

    private float _jumpForce;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _jumpForce = Mathf.Sqrt(_jumpHeight * ConstPhysicsValue * (Physics2D.gravity.y * _rigidbody.gravityScale));
    }

    public void Jump()
    {
        _rigidbody.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
    }
}
