using UnityEngine;
using System.IO;
using TMPro; // Add this namespace

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    private string filePath;

    public GameObject scoreObject;

    void Start()
    {
        filePath = Application.dataPath + "/score.txt";
        Debug.Log(score);
        scoreObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score; // Change to TextMeshProUGUI

    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "ScoreTag")
        {
            score++;
            Debug.Log(score);
            scoreObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score; // Change to TextMeshProUGUI
            WriteScoreToFile();
        }
    }

    void WriteScoreToFile()
    {
        File.WriteAllText(filePath, "Score: " + score);
    }
}


