using UnityEngine;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
