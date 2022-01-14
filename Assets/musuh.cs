using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuh : MonoBehaviour
{
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.Find("pesawat").transform);
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider other) {
    	if(other.gameObject.tag == "peluru"){
    		Destroy(other.gameObject);
    		Destroy(gameObject);
    		int score = int.Parse(GameObject.Find("score").GetComponent<UnityEngine.UI.Text>().text);
    		score++;
    		GameObject.Find("score").GetComponent<UnityEngine.UI.Text>().text = score.ToString();  		
    	}
    	if(other.gameObject.tag == "musuh") {
    		StopAllCoroutines();
    		Time.timeScale = 0;
    		GameObject.Find("pesawat").GetComponent<pesawat>().gameover();
    	}
    }
}
