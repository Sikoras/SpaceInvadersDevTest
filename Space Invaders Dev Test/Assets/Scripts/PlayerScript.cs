using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;

    public int bulletCount;

    public int lives = 3;

    [SerializeField]
    private float speed = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Input.GetAxis("Horizontal")*speed, 0, 0);
        if (Input.GetKeyDown("space"))
        {
            if (bulletCount < 3)
            {
                Vector3 bulletPos = new Vector3(this.transform.position.x, bullet.transform.position.y);
                Instantiate(bullet, bulletPos ,this.transform.rotation);

            }
        }

        

	}

    public void bulletCountMinus()
    {
        Debug.Log("Minus");
        int count = -1;
        bulletCount += count;
    }

    void OnTriggerEnter(Collider collide)
    {
        Debug.Log(collide.name);
    }

    public void losealife()
    {
        if(lives > 0)
        {
            lives+= -1;
        }else
        {
            Application.LoadLevel(3);
        }
    }
}
