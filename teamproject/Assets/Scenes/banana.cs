
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class banana : MonoBehaviour
{
    public GameObject bananaword;
    public TextMeshPro myText;
    
    void OnMouseDown(){
    	if(grab2.inHand1){
    		Destroy(bananaword);
    		myText.text = "O";
    	
		}
    }

}

}
