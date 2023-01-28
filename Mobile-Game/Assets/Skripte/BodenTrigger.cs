using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodenTrigger : MonoBehaviour
{ 
    

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("PlayerArmature").SendMessage("PlayDeathSound");
        Invoke("ResetCharakter", 2f);
        
    	

    }

    void ResetCharakter()
    {
        GameObject.Find("PlayerArmature").SendMessage("ResetCharacter");
    }
}


