<<<<<<< HEAD:teamproject/Assets/banana.cs
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
=======
﻿using System.Collections;
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
>>>>>>> fd5e8a68c0705c73089a4f6caee6b06f0ad4009e:teamproject/Assets/Scenes/banana.cs
