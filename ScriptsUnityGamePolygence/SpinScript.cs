using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0.1f, 0.0f, 0.0f);
    }
}
