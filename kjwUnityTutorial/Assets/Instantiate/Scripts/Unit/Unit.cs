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

        // 1. Target�� ���� - �ڽ��� ��ġ ����
        direction = target.transform.position - transform.position;
        targetDirection = target.transform.position;

        // 2. y���� 0���� ����.
        targetDirection.y = 0;
        direction.y = 0;

        // 3. ������ ����ȭ
        direction.Normalize();

        // 4. Ư���� ����� �ٶ�
        transform.LookAt(targetDirection);

        // 5. ���� ���͸� ���� ������
        transform.position += direction * speed * Time.deltaTime;
    }

    public virtual void Attack()
    {
        animator.SetBool("Attack", true);
    }

    public virtual void Die()
    { 
        
    }

    // Trigger �浹�� �Ǿ��� �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        state = State.Attack;
    }

    // Trigger�� �浹 ���� �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // Trigger �浹�� ������ �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        state = State.Move;
    }
}
