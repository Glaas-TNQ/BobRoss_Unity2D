using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

   
    
    void Start(){

     

    }
 
    public void Clear(){
            GameObject[] projectiles = GameObject. FindGameObjectsWithTag("Player_Projectile");
            for(int i=0; i< projectiles. Length; i++)
            {
            Destroy(projectiles[i]);
            }
    }
    
    

    void Update(){
                if (Input.GetKeyDown(KeyCode.C)){Clear();}
        
    }

}

