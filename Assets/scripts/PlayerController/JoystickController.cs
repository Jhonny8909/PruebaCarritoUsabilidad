using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public Joystick joystick;
    public float velocidad;
    public Rigidbody2D rb;
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;

    public GameObject buscador;

    // Start is called before the first frame update
    void Start()
    {
        buscador = GameObject.FindGameObjectWithTag("Joystick");
        joystick = buscador.GetComponent<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;

        gameObject.transform.Translate(direction * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
}
