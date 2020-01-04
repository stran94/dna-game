using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject menuPanel;
    public GameObject gamePanel;

    public void HideMenu()
    {
        menuPanel.SetActive(false);
    }

    public void ShowMenu()
    {
        menuPanel.SetActive(true);
    }

    public void HideGame()
    {
        gamePanel.SetActive(false);
    }

    public void ShowGame()
    {
        gamePanel.SetActive(true);
    }

    public void HideGameOver()
    {
        gameOverPanel.SetActive(false);
    }
    public void EndGame()
    {
        gameOverPanel.SetActive(true);
    }
}
