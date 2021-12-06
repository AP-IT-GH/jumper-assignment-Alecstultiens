using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.MLAgents;
using UnityEngine;


/*
 * Singleton to globally collect the Scores of all Players.
 * When a new Highscore is reached, it is added to Tensorboard.
 */
public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;

    [SerializeField] private TextMeshProUGUI display;

    private StatsRecorder statsRecorder;
    void Awake()
    {
        Instance = this;
        statsRecorder = Academy.Instance.StatsRecorder;
    }

    public void ResetScore()
    {
        statsRecorder.Add("Score: ", 0, StatAggregationMethod.MostRecent);
        display.text = "0";
    }

    public void AddScore(int score)
    {
        
        display.text = score.ToString();
        statsRecorder.Add("Score: ", score, StatAggregationMethod.MostRecent);
        

    }
}
