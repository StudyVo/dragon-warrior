using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public static bool bossDefeated = false;

    void Start()
    {
        currentHealth = maxHealth;
        bossDefeated = false; // reset trạng thái khi bắt đầu
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Boss nhận damage. HP còn lại: " + currentHealth);

        if (currentHealth <= 0)
        {
            bossDefeated = true;
            Debug.Log("🔥 Boss đã bị tiêu diệt!");
            Destroy(gameObject);
        }
    }
}