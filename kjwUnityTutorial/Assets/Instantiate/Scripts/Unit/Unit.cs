using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 5.0f;

    private void Awake()
    {
        target = GameObject.Find("Player");
    }

    public void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        // 1. Target�� ���� - �ڽ��� ��ġ ����
        direction = target.transform.position - transform.position;

        // 2. y���� 0���� ����.
        direction.y = 0;

        // 3. ������ ����ȭ
        direction.Normalize();

        // 4. Ư���� ����� �ٶ�
        transform.LookAt(target.transform);

        // 5. ���� ���͸� ���� ������
        transform.position += direction * speed * Time.deltaTime;
    }

    // Trigger �浹�� �Ǿ��� �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        speed = 0;
    }

    // Trigger�� �浹 ���� �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // Trigger �浹�� ������ �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
