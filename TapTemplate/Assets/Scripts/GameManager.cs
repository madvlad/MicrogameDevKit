using System.Collections;
using System.Collections.Generic;
using Assets.Mocks;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool HasWon = false;

    public GameObject EasyBalls;
    public GameObject MediumBalls;
    public GameObject HardBalls;

    private int difficulty;
    private int scoreToWin;
    private int currentScore;

    private void Start()
    {
        Time.timeScale = MockCoreManager.CurrentTimeScale;
        difficulty = MockCoreManager.difficulty;

        switch(difficulty)
        {
            case 0:
                EasyBalls.SetActive(true);
                scoreToWin = 4;
                break;
            case 1:
                MediumBalls.SetActive(true);
                scoreToWin = 7;
                break;
            case 2:
                HardBalls.SetActive(true);
                scoreToWin = 12;
                break;
            default:
                EasyBalls.SetActive(true);
                scoreToWin = 4;
                break;
        }
    }

    void EndGame()
    {
        MockCoreManager.WonGame = HasWon;
    }

    public void GetPop()
    {
        currentScore++;

        if (currentScore >= scoreToWin)
        {
            HasWon = true;
        }
    }
}
