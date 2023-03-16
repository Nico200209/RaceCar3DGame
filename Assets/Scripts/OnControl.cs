using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnControl : MonoBehaviour
{
    public GameObject Anymore;
    // Start is called before the first frame update
    void Start()
    {
        Anymore.GetComponent<BetterControl>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
