using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
   public GameObject grassword;
    
     
     void OnMouseDown(){
             
        if(grab.inHand1)
             Destroy(grassword);
         
     }
}
