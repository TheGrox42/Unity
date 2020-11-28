using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int rotate = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime, rotate * Time.deltaTime, rotate * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rotate = 50;
            collision.gameObject.GetComponent<Player>().score += 10;
        }
    }
}
