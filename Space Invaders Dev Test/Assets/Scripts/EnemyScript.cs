using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private Vector3 startPoint;
    private float rightX;

    private bool moveRight;

    [SerializeField]
    private float speed = 0.05f;

    // Use this for initialization
    void Start () {
        startPoint = this.transform.position;
        rightX = startPoint.x + 8;
        moveRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (moveRight)
        {
            transform.Translate(Vector2.right * speed);
            if (this.transform.position.x >= rightX)
            {
                goDown();
                moveRight = false;
            }
        }
        else
        {
            transform.Translate(-Vector2.right * speed);
            if (this.transform.position.x <= startPoint.x)
            {
                goDown();
                moveRight = true;
            }
        }
	}

    void goDown()
    {
        transform.Translate(-Vector2.up * speed);
    }
}
