using UnityEngine;
using UnityEngine.UI;

public class SlimeController : MonoBehaviour
{
    public Image HPBar;
    public float hp = 100f;

    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        HPBar.fillAmount = hp / 100f;
    }

    // ฟังก์ชันรับความเสียหาย
    public void TakeDamage(float damage)
    {
        hp -= damage;
        hp = Mathf.Clamp(hp, 0f, 100f); // กันค่าติดลบ

        if (hp <= 0f)
        {
            Die(); // เรียกฟังก์ชันตาย
        }
    }

    // ฟังก์ชันตาย
    void Die()
    {
        // ลบวัตถุ Slime ออกจากเกม
        Destroy(gameObject);
        // หรือทำอนิเมชันตายก่อนค่อยลบก็ได้
        // Animator animator = GetComponent<Animator>();
        // animator.SetTrigger("Die");
        // Destroy(gameObject, 1f); // รอ 1 วินาทีให้อนิเมชันเล่น
    }
}
