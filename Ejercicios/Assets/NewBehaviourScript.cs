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
   
    int l = 10;
    int m = 20;

    // Start is called before the first frame update
    void Start()
    {

        for (int n = 0; n < 10; n++)
        {
            print(n);
            if (n > 3)

            {
                print(mensaje);
            }
        }
         
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
