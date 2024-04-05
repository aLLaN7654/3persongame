using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody greandePrefab;
    public Transform grenadeSourceTransform;

    public float force = 100;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenade = Instantiate(greandePrefab);
            grenade.transform.position = grenadeSourceTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenadeSourceTransform.forward * force);
        }
    }
}
