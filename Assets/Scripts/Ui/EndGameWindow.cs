using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EndGameWindow : MonoBehaviour
{
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _restartButton;

    public event UnityAction Exit;
    public event UnityAction Restart;

    private void OnEnable()
    {
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    private void OnDisable()
    {
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
    }

    public void Activate()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    private void Deactivate()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    private void OnExitButtonClick()
    {
        Exit?.Invoke();
        Deactivate();
    }

    private void OnRestartButtonClick()
    {
        Restart?.Invoke();
        Deactivate();
    }
}
