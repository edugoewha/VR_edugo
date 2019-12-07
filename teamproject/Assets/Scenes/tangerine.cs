using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tangerine : MonoBehaviour
{
   public GameObject tangerineword;
    
     
     void OnMouseDown(){
             
        if(grab.inHand4)
             Destroy(tangerineword);
         
     }
}
