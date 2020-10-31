using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class AppleLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-5.275f, 5.275f);
        float y = Random.Range(-4.735f, 4.735f);


        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        SnakeLife s = collision.gameObject.GetComponent<SnakeLife>();
        if(s != null)
        {
            s.addChank();
            s.snakeScore++;
            Destroy(gameObject);
        }
    }
}
