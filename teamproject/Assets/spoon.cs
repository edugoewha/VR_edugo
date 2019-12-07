using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spoon : MonoBehaviour
{
   public GameObject spoonword;
    void OnMouseDown(){
    	if(grab2.inHand3)
    		Destroy(spoonword);
    }
}
