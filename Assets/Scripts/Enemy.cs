using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Transform player;   // ������
    public float speed = 3f;   // ���������ѵ��

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //linkStarto
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // �Թ����Ҽ�����
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );

            // �ѹ˹����Ҽ�����
            Vector3 direction = (player.position - transform.position).normalized;
            transform.forward = direction;
        }
<<<<<<< Updated upstream
    }
=======
    } //555555555 //Seg
>>>>>>> Stashed changes
}




