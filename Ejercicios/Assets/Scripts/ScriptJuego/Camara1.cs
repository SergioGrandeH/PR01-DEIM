using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
   
    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        print(playerObject.transform.position);

        //NO SE HACE ASÍ
        //transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, transform.position.z);

        //SE HACE ASÍ  
        //float newx = playerObject.transform.position.x;
        //float newy = playerObject.transform.position.y;
        //float newz = transform.position.z;

        //transform.position = new Vector3(newx, newy, newz);




    }

}
