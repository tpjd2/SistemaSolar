using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionaObjeto : MonoBehaviour
{
    [SerializeField] float velocidade;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velocidade * Time.deltaTime);
    }
}
