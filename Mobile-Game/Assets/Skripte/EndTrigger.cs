using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("PlayerArmature").SendMessage("EndTimer");
    }
}
