using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int player1, player2;
    public Score scoreLeft, scoreRight;
    

    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
        {
            player1++;
        }
        if (id == 2)
        {
            player2++;
        }
        UpdateScores();
    }
    private void UpdateScores()
    {
        scoreLeft.SetScore(player1);
        scoreRight.SetScore(player2);
    }
}
