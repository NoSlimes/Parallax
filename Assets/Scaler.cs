using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scaler : MonoBehaviour
{
    public InputField input;
    public GameObject scaleThingIdk;
    float thing;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thing = float.Parse(input.text);
        scaleThingIdk.transform.localScale = new Vector3(thing, thing, thing);
    }
}
