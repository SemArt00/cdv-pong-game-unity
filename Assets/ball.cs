using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;
    public float speed = 2.5f;
    public Vector2 velocity;
    public TextMeshProUGUI leftPlayerSkoreText;
    public TextMeshProUGUI rightPlayerSkoreText;
    private int leftPlayerSkore;
    public int rightPlayerSkore;

    // Start is called before the first frame update
    void Start()
    {
        leftPlayerSkore = 0;
        leftPlayerSkoreText.text = leftPlayerSkore.ToString();
        rightPlayerSkore = 0;
        rightPlayerSkoreText.text = rightPlayerSkore.ToString();
        rigidbody2D = GetComponent<Rigidbody2D>();
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        rigidbody2D.velocity = new Vector2(randomX, randomY).normalized * speed;
        velocity = rigidbody2D.velocity;
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody2D.velocity = Vector2.Reflect(velocity, collision.contacts[0].normal);
        velocity = rigidbody2D.velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
            leftPlayerSkore += 1;
            leftPlayerSkoreText.text = leftPlayerSkore.ToString();  
        if (transform.position.x < 0)
            rightPlayerSkore += 1;
            rightPlayerSkoreText.text = rightPlayerSkore.ToString();
        

            rigidbody2D.velocity = Vector2.zero;
            transform.position = Vector2.zero;
            float randomX = Random.Range(-1f, 1f);
            float randomY = Random.Range(-1f, 1f);
            rigidbody2D.velocity = new Vector2(randomX, randomY).normalized * speed;
            velocity = rigidbody2D.velocity;
    }
}
