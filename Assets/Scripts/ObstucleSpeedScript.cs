using UnityEngine;

public class ObstucleSpeedScript : MonoBehaviour
{
    public float speed = -3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
}
