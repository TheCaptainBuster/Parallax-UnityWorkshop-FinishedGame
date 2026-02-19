using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }
}
