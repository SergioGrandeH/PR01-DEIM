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
    int l = 10;
    int m = 20;

    // Start is called before the first frame update
    void Start()
    {
        while (n != 4) 
        {
            n = Random.Range(-1000, 1000);

            print(n);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
   
    }
}
