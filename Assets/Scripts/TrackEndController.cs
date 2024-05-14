using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackEndController : MonoBehaviour
{
    //çarpn þey "platform" ise trigger fonksiyonu çalýþýr
    //trigger fonksiyonu playformun hareket yönünü -1 ile çarparak deðiþtirir
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Platform") return;
        var platform = other.gameObject.GetComponent<PlatfromController>();
        platform.moveSpeed *= -1;
    }


}
