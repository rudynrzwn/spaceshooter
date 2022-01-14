using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesawat : MonoBehaviour
{
   public GameObject peluru, tembak1, tembak2,pesawatmusuh, game_over;
   public float speed;

   void Start(){
   	StartCoroutine(pesawat_musuh(pesawatmusuh));
   }
   public void control(){
   	if (Input.GetKey(KeyCode.RightArrow)){
   		transform.Rotate(0 ,speed, 0);
   	}
   	if (Input.GetKey(KeyCode.LeftArrow)){
   		transform.Rotate(0 ,-speed, 0);
   	}
   	if (Input.GetKey(KeyCode.Space)){
   		GameObject peluru1 = Instantiate(peluru, tembak1.transform.position, transform.rotation);
   		GameObject peluru2 = Instantiate(peluru, tembak2.transform.position, transform.rotation);
   	}

   }

   IEnumerator pesawat_musuh(GameObject pesawat){
   	while (true){
   	yield return new WaitForSeconds(1f);
   	float posisi = Random.Range(-9.5f, 9.5f);
   	GameObject pesawatmusuh = Instantiate(pesawat, new Vector3(posisi, 0, 5.5f), pesawat.transform.rotation);
   }
   }

   public void gameover(){
   	game_over.SetActive(true);
   }

   public void restart(){
   	Time.timeScale = 1f;
   	Application.LoadLevel(Application.loadedLevelName);
   }

    
    void Update()
    {
        control();
    }
}
