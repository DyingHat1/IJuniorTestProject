using UnityEngine;
using UnityEngine.UI;
using IJunior.TypedScenes;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _authorsButton;
    [SerializeField] private AuthorsWindow _authors;

    private void OnEnable()
    {
        _startButton.onClick.AddListener(OnStartButtonCLick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _authorsButton.onClick.AddListener(OnAuthorsButtonClick);
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveListener(OnStartButtonCLick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
        _authorsButton.onClick.RemoveListener(OnAuthorsButtonClick);
    }

    private void OnStartButtonCLick()
    {
        Game.Load();
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }   
    
    private void OnAuthorsButtonClick()
    {
        _authors.Activate();
    }    
}
