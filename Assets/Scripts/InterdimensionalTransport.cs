using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InterdimensionalTransport : MonoBehaviour {

    public Material[] materials;

	// Use this for initialization
	void Start () {
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.name != "Main Camera") {
            return;
        }

        //Outside of other world
        if (transform.position.z > other.transform.position.z) {
            Debug.Log("Outside of other World!!");
            foreach (var mat in materials) {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
            
        }
        else
        {
            Debug.Log("Inside of other World!!");
            foreach (var mat in materials) {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
        }
    }

    private void OnDestroy()
    {
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
