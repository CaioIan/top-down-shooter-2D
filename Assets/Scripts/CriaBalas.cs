using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaBalas : MonoBehaviour
{
    public GameObject balas;

    public GameObject cano;

    public AudioSource shot;

    // Start is called before the first frame update
    void Start()
    {
        shot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(balas, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.z), cano.transform.rotation);
            shot.Play(); 
        }
    }

    
}
