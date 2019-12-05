using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public GameObject rockword;
    
     
     void OnMouseDown(){
             
        if(grab.inHand5)
             Destroy(rockword);
         
     }
}
