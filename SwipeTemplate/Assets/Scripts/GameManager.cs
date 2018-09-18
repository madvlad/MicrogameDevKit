using System.Collections;
using System.Collections.Generic;
using Assets.Mocks;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool HasWon = false;

    private void Start()
    {
        Time.timeScale = MockCoreManager.CurrentTimeScale;
    }

    void EndGame()
    {
        if (HasWon)
        {
            MockCoreManager.WonGame = true;
        }
    }
}
