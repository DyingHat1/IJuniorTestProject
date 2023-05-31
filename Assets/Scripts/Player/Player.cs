using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(GroundChecker))]
[RequireComponent(typeof(PlayerJumper))]
public class Player : MonoBehaviour
{
    private GroundChecker _groundChecker;
    private PlayerJumper _jumper;
    private bool _canJump = false;
    private CoinsCollector _coinsCollector;

    public event UnityAction Defeat;

    private void Awake()
    {
        _jumper = GetComponent<PlayerJumper>();
        _groundChecker = GetComponent<GroundChecker>();
    }

    private void OnEnable()
    {
        _groundChecker.Grounded += OnGrounded;
    }

    private void OnDisable()
    {
        _groundChecker.Grounded -= OnGrounded;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _canJump)
        {
            _jumper.Jump();
            _canJump = false;
        }
    }

    public void Init(CoinsCollector coinsCollector)
    {
        _coinsCollector = coinsCollector;
        enabled = true;
    }

    public void Die()
    {
        Defeat?.Invoke();
    }

    public void CollectCoin()
    {
        _coinsCollector?.AddCoin();
    }

    private void OnGrounded()
    {
        _canJump = true;
    }
}
