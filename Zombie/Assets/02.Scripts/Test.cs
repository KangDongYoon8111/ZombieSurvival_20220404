using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        Getter getter = new Getter();
        getter.SetMyField(10);
        Debug.Log(getter.GetMyField());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
