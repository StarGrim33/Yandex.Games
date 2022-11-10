using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _mainMenu;

    public void StartGame()
    {
        _mainMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
