using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    public Rigidbody2D myRigidBody;

    int angkaCoba = 500;
    string namaPercobaan = "Ikan tongkol";
    float speed = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        //print("hello");
        //Debug.Log("test 123 dicoba");
        //Debug.Log("nama saya adalah " + namaPercobaan);
        //Debug.LogWarning("ini bakal ada " + angkaCoba + " iterasi");
        //Debug.LogError("Kecepatannya adalah " + speed);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            myRigidBody.velocity = new Vector2 (0f, 10f);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) 
        {
            myRigidBody.velocity = new Vector2(0f, -10f);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            myRigidBody.velocity = new Vector2(10f, 0f);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            myRigidBody.velocity = new Vector2(-10f, 0f);
        }

        if (transform.position.x > 9.5f)
        {
            Debug.LogWarning("Kotak keluar dari sisi kanan");
        } else if(transform.position.x < -9.5f)
        {
            Debug.LogWarning("kotak keluar dari sisi kiri");
        }

        if (transform.position.y > 5.5f)
        {
            Debug.LogWarning("kotak menujju langit biru");
        }
    }
}
