using UnityEngine;

public class Player_State : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage (float amount) {
        health -= amount;
        if(health <= 0f) {
            Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
