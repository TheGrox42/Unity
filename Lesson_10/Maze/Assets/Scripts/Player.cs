using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    float speed = 800;
    public int score = 0;
    private Rigidbody rg;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            //GetComponent<Rigidbody>().velocity += new Vector3(0.5f, 0, 0);
            rg.AddForce(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }else if(Input.GetAxis("Horizontal") > 0){
            //GetComponent<Rigidbody>().velocity -= new Vector3(0.5f, 0, 0);
            rg.AddForce(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            //GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 0.5f);
            rg.AddForce(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") > 0){
            //GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, 0.5f);
            rg.AddForce(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
    }
}
