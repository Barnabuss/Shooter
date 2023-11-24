using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Bonus;
    public Rigidbody2D monRigidBody;
    public Transform parent;
    public float speed;
    public GrosTas grosennemi;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "petitennemi")
        {
            
            Instantiate(Bonus, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "GrosEnnemi")
        {

           
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }



    }





}
