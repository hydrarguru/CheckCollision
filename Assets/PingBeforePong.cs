using System.Collections;
using UnityEngine;

public class PingBeforePong : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2f, 2f) - 1f, transform.position.y, transform.position.z);
    }
}
