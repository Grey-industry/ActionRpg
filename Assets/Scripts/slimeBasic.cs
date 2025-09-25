using UnityEngine;
using UnityEngine.UI;

public class slimeBasic : MonoBehaviour
{
    [Header("HP Settings")]
    public float maxHP = 100f;
    private float currentHP;

    [Header("UI")]
    public Image HPBar;  // ลาก Image UI ของ Slime ลงใน Inspector

    [Header("Audio")]
    public AudioClip hitSound;
    private AudioSource audioSource;

    private void Start()
    {
        currentHP = maxHP;

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (HPBar != null)
        {
            HPBar.fillAmount = currentHP / maxHP;
        }
    }

    // ฟังก์ชันเรียกเมื่อโดนโจมตี
    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        currentHP = Mathf.Clamp(currentHP, 0f, maxHP);

        // เล่นเสียงโดนโจมตี
        if (hitSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(hitSound);
        }

        UpdateUI();

        // ตรวจสอบว่า HP = 0
        if (currentHP <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        // คุณสามารถเพิ่มเอฟเฟกต์ตายหรืออนิเมชันตรงนี้ได้
        Destroy(gameObject);
    }

    // ตัวอย่างใช้ Trigger กับดาบ
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            // สมมติดาบทำดาเมจ 10
            TakeDamage(10f);
        }
    }
}
