using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    int angkaCoba = 500;
    string namaPercobaan = "Ikan tongkol";
    float speed = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        print("hello");
        Debug.Log("test 123 dicoba");
        Debug.Log("nama saya adalah " + namaPercobaan);
        Debug.LogWarning("ini bakal ada " + angkaCoba + " iterasi");
        Debug.LogError("Kecepatannya adalah " + speed);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("tombol spasi tertekan");
        }
    }
}
