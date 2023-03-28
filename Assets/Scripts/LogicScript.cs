using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    private int playerScore;

    // increase the current score by s
    public void addScore(int s)
    {
        playerScore += s;
        scoreText.text = playerScore.ToString();
    }

}
