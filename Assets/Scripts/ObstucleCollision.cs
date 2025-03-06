using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstucleCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private AssetBundle myLoadedAssetBundle;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when the collider attached to this GameObject collides with another collider
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstucle") 
        {
            SceneManager.LoadScene(1);
        }
    }
}
