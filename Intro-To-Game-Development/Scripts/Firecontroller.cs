using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firecontroller : MonoBehaviour
{
    public GameObject ProjectileObject;

    public void Fire()
    {
        Instantiate(ProjectileObject, transform.position, transform.rotation);
    }
}

