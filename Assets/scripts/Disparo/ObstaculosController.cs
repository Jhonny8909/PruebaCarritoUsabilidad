using UnityEngine;

public class ObstaculosController : MonoBehaviour
{
    public int vida = 3;
   private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.CompareTag("Bala"))
       {
           Destroy(gameObject);
           Destroy(collision.gameObject);
       }
   }

}
