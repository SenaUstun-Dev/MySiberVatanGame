using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f; // arabanin hareket hizi

    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // arabayi ileriye dogru hareket ettir.
    }
}
