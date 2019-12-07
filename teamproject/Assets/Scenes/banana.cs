using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{
    public GameObject bananaword;
    void OnMouseDown(){
    	if(grab2.inHand)
    		Destroy(bananaword);
    }
}
