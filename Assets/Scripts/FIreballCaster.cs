using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIreballCaster : MonoBehaviour
{
    public Fireball fireballPrefab;
    public Transform fireballpointTransform;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballpointTransform.position, fireballpointTransform.rotation);
        }
    }
}
