using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private float speed = 0.1f;

    public bool isEnemyBullet;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isEnemyBullet)
        {

            transform.Translate(Vector2.up * speed);
        }else
        {
            transform.Translate(-Vector2.up * speed);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (!isEnemyBullet)
        {
            Debug.Log("HIT");
            if (collision.collider.tag == "Enemy")
            {
                Player.GetComponent<PlayerScript>().bulletCountMinus();
                Destroy(collision.gameObject);
                Destroy(gameObject);


            }
            if (collision.collider.tag == "OutofBounds")
            {
                Player.GetComponent<PlayerScript>().bulletCountMinus();
                Destroy(gameObject);

            }
        }else
        {
            if(collision.collider.tag == "Player")
            {
                Player.GetComponent<PlayerScript>().losealife();
                Destroy(gameObject);
            }
        }
        
    }
}
