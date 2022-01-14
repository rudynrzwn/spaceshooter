using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour
{   
	public float speed;  
	public float jarak_tembak;	
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
        if(transform.position.x >jarak_tembak || transform.position.x < -jarak_tembak || transform.position.z >jarak_tembak || transform.position.z < -30){
        	Destroy(gameObject);
        } 
    }

    
}
