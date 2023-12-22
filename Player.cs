using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyMover enemy))
        {
            Destroy(enemy.gameObject);
        }
    }
}
