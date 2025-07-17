using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName = "Level2";

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && BossHealth.bossDefeated)
        {
            Debug.Log("Đã chạm cửa - bossDefeated: " + BossHealth.bossDefeated);
            Debug.Log("✅ Boss defeated, chuyển cảnh sang " + nextSceneName);
            SceneManager.LoadScene(nextSceneName);
        }
    }
}