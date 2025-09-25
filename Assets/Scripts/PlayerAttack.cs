using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float damage = 2f;
    public float attackRange = 1f;

    void Update()
    {
        // เช็คคลิกซ้ายเมาส์ 1 ครั้ง
        if (Input.GetMouseButtonDown(0))   // 0 = เมาส์ซ้าย, 1 = เมาส์ขวา, 2 = เมาส์กลาง
        {
            Attack();
        }
    }

    void Attack()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, attackRange);
        foreach (Collider hit in hits)
        {
            if (hit.CompareTag("Slime"))
            {
                slimeBasic slime = hit.GetComponent<slimeBasic>();
                if (slime != null)
                {
                    slime.TakeDamage(damage);
                }
            }
        }
    }
}
