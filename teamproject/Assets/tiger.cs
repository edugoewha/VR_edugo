using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiger : MonoBehaviour
{
    public GameObject tigerword;
    void OnMouseDown(){
    	if(grab2.inHand2)
    		Destroy(tigerword);
    }
}
