using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeAvatar : MonoBehaviour {

	public GameObject YourSprite;
	bool isActive = false;    

 void Update () {

     if (Input.GetMouseButtonDown (0)) {

         isActive = !isActive;
     }

     if (isActive) {
 
         YourSprite.SetActive (false);

     } else {

         YourSprite.SetActive(true);

     }
 }
}
