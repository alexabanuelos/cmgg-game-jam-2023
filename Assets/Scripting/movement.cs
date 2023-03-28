using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] [Range(0, 0.1f)] private float speed;
    private Transform _Transform;
    // Start is called before the first frame update
    void Start()
    {
        _Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _Transform.position += (Vector3) Vector2.up * speed;
        } 
    }
}
