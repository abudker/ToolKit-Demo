using UnityEngine;
using System.Collections;

public class attachObject : MonoBehaviour {


	void Awake () {
	
	}
	
	void FixedUpdate () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            gameObject.AddComponent<FixedJoint>();
            var rb = other.gameObject.GetComponent<Rigidbody>();
            gameObject.GetComponent<FixedJoint>().connectedBody = rb;
        }
    }

    void OnTriggerExit(Collider other)
    {

        var rb = other.gameObject.GetComponent<Rigidbody>();

        if (rb != null && gameObject.GetComponent<FixedJoint>().connectedBody == rb)
        {   
           Destroy(gameObject.GetComponent<FixedJoint>());
        }
        
    }
}
