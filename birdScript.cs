using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapSrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapSrenght;
        }
        if (transform.position.y > 7 || transform.position.y < -7)
        {
            logic.gameOver();
        }
    }
        private void OnCollisionEnter2D (Collision2D collision)
    {
            logic.gameOver();
            birdIsAlive = false;
    }
}