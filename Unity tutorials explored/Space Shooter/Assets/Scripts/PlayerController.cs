using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary
{
    public float xMin, xMax, zMin, zMax;

}
public class PlayerController : MonoBehaviour {


    public float speed;
    
    

	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;
        
        //GetComponent<Rigidbody>().position = new Vector3
        //(
        //    mathf.clamp(getcomponent<rigidbody>().position.x, boundary.xmin, boundary.xmax),
        //    0.0f,
        //    mathf.clamp(getcomponent<rigidbody>().position.z, boundary.zmin, boundary.zmax)
        //);


    }
}
