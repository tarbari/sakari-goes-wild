using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision) 
    {
      if(collision.gameObject.tag == "downstairs") {

				SceneManager.LoadScene("Labyrintti");
				
			} 
			else if(collision.gameObject.tag == "outdoor") {

				SceneManager.LoadScene("Overworld");
				
			} 

			else if(collision.gameObject.tag == "SakariHouse") {

				SceneManager.LoadScene("HouseSakari");
				
			} 
			else if(collision.gameObject.tag == "EkiHouse") {

				SceneManager.LoadScene("HouseEki");
				
			} 
    }


}