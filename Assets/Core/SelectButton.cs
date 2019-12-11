using System.Collections;
using System.Collections.Generic;
using Completed;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButton : MonoBehaviour
{
    public GameManager.PLAYER playerType;

    public void StartGame()
    {
        GameManager.playerType = playerType;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
