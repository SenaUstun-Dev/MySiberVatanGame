using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackEndController : MonoBehaviour
{
    //�arpn �ey "platform" ise trigger fonksiyonu �al���r
    //trigger fonksiyonu playformun hareket y�n�n� -1 ile �arparak de�i�tirir
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Platform") return;
        var platform = other.gameObject.GetComponent<PlatfromController>();
        platform.moveSpeed *= -1;
    }


}
