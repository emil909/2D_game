using UnityEngine;

public class jumpScript : MonoBehaviour
{
    public int speed = 10;
    public Rigidbody2D rb;
    private int canJump = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump < 2)
        {
            rb.linearVelocity = new Vector2(0, speed);
            canJump++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = 0;
        }
    }
}
