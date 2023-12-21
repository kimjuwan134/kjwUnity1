using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Move,
    Attack,
    Die
}

public abstract class Unit : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Vector3 targetDirection;
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 5.0f;
    [SerializeField] State state;
    [SerializeField] Animator animator;

    private void Awake()
    {
        target = GameObject.Find("Player");
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        switch(state)
        {
            case State.Move: Move();
                break;
            case State.Attack: Attack();
                break;
            case State.Die: Die();
                break;
        }
    }

    public virtual void Move()
    {
        animator.SetBool("Attack", false);

        // 1. Target의 벡터 - 자신의 위치 벡터
        direction = target.transform.position - transform.position;
        targetDirection = target.transform.position;

        // 2. y축을 0으로 설정.
        targetDirection.y = 0;
        direction.y = 0;

        // 3. 벡터의 정규화
        direction.Normalize();

        // 4. 특정한 대상을 바라봄
        transform.LookAt(targetDirection);

        // 5. 방향 벡터를 가진 값으로
        transform.position += direction * speed * Time.deltaTime;
    }

    public virtual void Attack()
    {
        animator.SetBool("Attack", true);
    }

    public virtual void Die()
    { 
        
    }

    // Trigger 충돌이 되었을 때 이벤트를 호출하는 함수
    private void OnTriggerEnter(Collider other)
    {
        state = State.Attack;
    }

    // Trigger가 충돌 중일 때 이벤트를 호출하는 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // Trigger 충돌이 끝났을 때 이벤트를 호출하는 함수
    private void OnTriggerExit(Collider other)
    {
        state = State.Move;
    }
}
