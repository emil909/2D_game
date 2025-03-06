using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to load a new scene
    public void LoadNewScene()
    {
        SceneManager.LoadScene(0); // Replace "NewSceneName" with the actual name of the scene you want to load
    }
}
