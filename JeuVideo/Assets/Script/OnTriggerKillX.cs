using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        KillableX victim = other.GetComponent<KillableX>();

        if (victim != null)
        {
            victim.Kill();
        }
    }
}
