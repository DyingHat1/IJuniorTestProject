using IJunior.TypedScenes;
using UnityEngine;

public class ScenesLoader : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private EndGameWindow _endGameWindow;

    private void OnEnable()
    {
        _player.Defeat += OnDefeat;
        _endGameWindow.Restart += OnRestart;
        _endGameWindow.Exit += OnExit;
    }

    private void OnDisable()
    {
        _player.Defeat -= OnDefeat;
        _endGameWindow.Restart -= OnRestart;
        _endGameWindow.Exit -= OnExit;
    }

    private void OnDefeat()
    {
        _endGameWindow.Activate();
    }

    private void OnExit()
    {
        MainMenu.Load();
    }

    private void OnRestart()
    {
        Game.Load();
    }
}
