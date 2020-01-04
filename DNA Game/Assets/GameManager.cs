using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void HideGameOver()
    {
        gameOverPanel.SetActive(false);
    }
    public void EndGame()
    {
        gameOverPanel.SetActive(true);
    }
}
