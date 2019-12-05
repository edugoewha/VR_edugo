using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
	public GameObject waterword;
   
    
    void OnMouseDown(){
            
       if(grab.inHand2)
            Destroy(waterword);
        
    }
}
