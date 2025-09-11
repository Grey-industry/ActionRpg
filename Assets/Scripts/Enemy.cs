using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SlimeChasePlayer : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject player;

<<<<<<< Updated upstream
    public Transform player;   // ผู้เล่น
    public float speed = 3f;   // ความเร็วศัตรู
=======
    public float stopDistance = 1f;
    public float detectionRange = 10f;

    Animator anim;
    bool isPlayerInRange = false;
    bool hasReachePlayer = false;
>>>>>>> Stashed changes

    void Start()
    {
<<<<<<< Updated upstream
        
=======
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
>>>>>>> Stashed changes
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        isPlayerInRange = distance <= detectionRange;
        if (isPlayerInRange)
        {
<<<<<<< Updated upstream
            // เดินเข้าหาผู้เล่น
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );

            // หันหน้าไปหาผู้เล่น
            Vector3 direction = (player.position - transform.position).normalized;
            transform.forward = direction;
        }
    }
}



=======
            if (distance <= stopDistance)
            {
                StopMoving();
                hasReachePlayer = true;
            }
            else
            {
                MoveToPlayer();
                hasReachePlayer = false;
            }
        }
        else
        {
            StopMoving();
        }
>>>>>>> Stashed changes

    }
    void MoveToPlayer()
    {
        if (agent.isActiveAndEnabled)
        {
            agent.SetDestination(player.transform.position);
            hasReachePlayer = false;
        }
    }
    void StopMoving()
    {
        if (agent.isActiveAndEnabled)
        {
            agent.ResetPath();
            hasReachePlayer = true;
        }
    }
}