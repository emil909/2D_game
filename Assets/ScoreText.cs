using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        // Get the TextMeshProUGUI component attached to this GameObject
        textMeshPro = GetComponent<TextMeshProUGUI>();

        // Load the score from PlayerPrefs
        int score = PlayerPrefs.GetInt("Score", 0);

        // Update the text with the initial score
        if (textMeshPro != null)
        {
            textMeshPro.text = "Score: " + score;
        }
    }

    void Update()
    {
        // Load the score from PlayerPrefs
        int score = PlayerPrefs.GetInt("Score", 0);

        // Update the text with the current score
        if (textMeshPro != null)
        {
            textMeshPro.text = "Score: " + score;
        }
    }
}
