using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = 5f;
    private float h;
    private float v;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

    }
    void FixedUpdate()
    {
        
        if (h != 0 || v != 0)
        {

            //Vector2 force = new Vector2 (h, v).normalized * speed;
            //_rb.AddForce(force);


            Vector2 dir = new Vector2(h, v).normalized;
            if (dir != Vector2.zero)
            {
                Vector2 playerPosition = _rb.position + dir * (speed * Time.fixedDeltaTime);
                _rb.position = playerPosition;
            }
        }

    }
}
