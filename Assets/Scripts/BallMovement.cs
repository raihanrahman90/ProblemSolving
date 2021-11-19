using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseLocation = Input.mousePosition;
            Vector2 ballPosition = transform.position;
            float forceX = mouseLocation.x - ballPosition.x;
            float forceY = mouseLocation.y - ballPosition.y;
            rigidbody2D.AddForce(new Vector2(forceX*100, forceY*100));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            gameManager.addScore();
        }
    }
}
