using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("PlayerArmature").SendMessage("StartTimer");
    }
}
