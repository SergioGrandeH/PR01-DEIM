using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moodplayer1 : MonoBehaviour
{
    public float speed = 1;
    private Vector3 poscubo = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        /* Vector3 destPos = new Vector3(-1f, 0f,  0f);
        poscubo = poscubo + destPos * Time.deltaTime * speed;
         transform.position = poscubo;*/

        float delsplH = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * delsplH);
        float delsplV = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * delsplV);
    }
}
