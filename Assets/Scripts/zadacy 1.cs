using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadacy1 : MonoBehaviour
{

    public Transform point1;
    public Transform point2;

    private void Update()
    {
        transform.position = Vector3.Lerp(point1.position, point2.position, 0.5f);
    }
}
