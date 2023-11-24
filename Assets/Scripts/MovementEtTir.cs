using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bonus;
    //public GameObject changetaille;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public Bullet myBullet;

    public int score = 0;

    public TextMeshProUGUI myText;

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        myText.SetText("Score : 0");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bonus")
        {
            Debug.Log("oscur");
            Destroy(collision.gameObject);
            score++;
                    }
        if (collision.gameObject.tag == "Bonus2")
        {
            Debug.Log("oscur2");
            Destroy(collision.gameObject);
            score = score + 2;
        }

        myText.SetText("Score : " + score);


    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, parent.position, parent.rotation);
        }

        if(transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }

        
    }

}
