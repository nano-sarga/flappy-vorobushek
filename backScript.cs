using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backScript : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer sprite;

    public float speed = 1f;
    private float positionInX;
    private Vector3 restartPosition;
    void Awake()
    {
        restartPosition = transform.position;
        positionInX = sprite.bounds.size.x
                      * 2
                      - restartPosition.x;
    }
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -positionInX)
        {
            transform.position = restartPosition;
        }
    }
}
