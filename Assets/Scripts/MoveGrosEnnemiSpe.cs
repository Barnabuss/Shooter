using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrosTas : MonoBehaviour
{
    public GameObject Bonus2;
    public Transform limitL;
    public Transform limitR;
    public int PV = 2;
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

        if (PV <= 0)
        {
            Instantiate(Bonus2,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            PV -= 1;
        }
    }
}
