using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CollisionChecker : MonoBehaviour
{
    public GameObject globalvolume; 
    private Volume v;
    private Vignette vg;
    // Start is called before the first frame update
    void Start()
    {
        
        v = GameObject.Find("Global Volume").GetComponent<Volume>();
        v.profile.TryGet(out vg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        
            Debug.Log("quiere chocar");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("la wea fome culiao");
            vg.intensity.value = 0.5f;
        }  
        
    }

    void OnTriggerExit(Collider collision) {
        
            Debug.Log("quiere chocar");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("la wea fome culiao");
            vg.intensity.value = 0.0f;
        }  
        
    }
}
