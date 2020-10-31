using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking.Types;
public class Player : MonoBehaviour
{
    public KeyCode key1;
    public KeyCode key2;
    public Vector3 direction;

    public void FixedUpdate()
    {
        if (Input.GetKey(key1)) {
            GetComponent<Rigidbody>().velocity += direction;
        }
        
        if (Input.GetKey(key2)){
            GetComponent<Rigidbody>().velocity -= direction;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("finish")){
            ScreenManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);s
        }
    }
}
