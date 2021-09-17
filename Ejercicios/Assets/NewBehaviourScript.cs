using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Tipos de variables//

    public string mensaje = "Buenas tardes";
    public float numerodecimal = 1.2f ;
    public int numeroentero = 12;
    public bool vivo = true;
    int n = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        n++;
        if (n < 10)
        {
            print(n);
        }
        
    }
}
