using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fish : MonoBehaviour
{
    public GameObject fishword;
    void OnMouseDown(){
    	if(grab2.inHand5)
    		Destroy(fishword);
    }
}
