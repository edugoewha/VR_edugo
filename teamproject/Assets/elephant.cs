using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elephant : MonoBehaviour
{
    public GameObject elephantword;
    public Text status;
	void Start(){
		status = gameObject.GetComponentInChildren<Text>();
	}
    void OnMouseDown(){
    	if(grab2.inHand6)
    		Destroy(elephantword);
    }
}
