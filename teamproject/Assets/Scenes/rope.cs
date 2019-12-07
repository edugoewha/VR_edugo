using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
   public GameObject ropeword;
    
     
     void OnMouseDown(){
             
        if(grab.inHand3)
             Destroy(ropeword);
         
     }
}
