using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class AuthorsWindow : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private AnimationClip _windowCloseAnimation;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _closeButton.onClick.AddListener(OnCloseButtonClick);
    }

    private void OnDisable()
    {
        _closeButton.onClick.RemoveListener(OnCloseButtonClick);
    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    private void OnCloseButtonClick()
    {
        _animator.Play(_windowCloseAnimation.name);
    }
}
