using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public float velocidadBala = 10f;
    public float tiempoEntreDisparos = 0.5f;
    private float temporizadorDisparo = 0f;
    public float limiteY = 7;
    public int danioBala = 1;
    
    /*
    private void Start()
    {
        _pantallaAncho = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;
        _pantallaAltura = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).y;
    }
*/
    
    // Update is called once per frame
    void Update()
    {
        temporizadorDisparo += Time.deltaTime;
    
        if (temporizadorDisparo >= tiempoEntreDisparos)
        {
            Disparar();
            temporizadorDisparo = 0f;
        }
        // Comprobación de posición de la bala
        foreach (Transform bala in transform)
        {
            if (bala.position.y > limiteY)
            {
                Destroy(bala.gameObject);
            }
        }
    }
    
    public void Disparar()
    {
        GameObject bala = Instantiate(balaPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f, velocidadBala);
    }
}
