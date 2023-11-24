using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveennemi : MonoBehaviour
{
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public int PVpetit = 1;
    public float speedennemilateral = 0.02f;
    public float speedennemibas = 0.007f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
       
        transform.position += Vector3.right * speedennemilateral;
        transform.position += Vector3.down * speedennemibas;



        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }

        if (PVpetit <= 0)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            PVpetit -= 1;
        }
    }
}
