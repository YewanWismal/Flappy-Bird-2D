using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed =0.5f;
    public bool isMoving;
    private float leftEge;
    private Player player;
    private void Start()
    {
        leftEge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5f;
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (player.isDead)
        {
            isMoving = false;
        }
        if (isMoving == true  )
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x < leftEge)
        {
            Destroy(this.gameObject);
        }
    }
}
