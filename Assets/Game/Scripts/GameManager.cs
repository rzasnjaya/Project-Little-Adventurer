using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character playerCharacter;
    private bool gameIsOver;

    private void Awake()
    {
        playerCharacter = GameObject.FindWithTag("Player").GetComponent<Character>();    
    }

    private void GameOver()
    {
        Debug.Log("GAME OVER");
    }

    public void GameIsFinished()
    {
        Debug.Log("GAME IS FINISHED");
    }

    void Update()
    {
        if(gameIsOver)
        {
            return;
        }

        if(playerCharacter.CurrentState == Character.CharacterState.Dead)
        {
            gameIsOver = true;
            GameOver();
        }
    }
}
