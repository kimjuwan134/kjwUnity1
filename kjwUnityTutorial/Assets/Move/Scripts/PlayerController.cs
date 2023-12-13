using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        //Input.GetAxis() : Ư���� Key�� ���� �� -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ�.
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // ������ ����ȭ
        direction.Normalize();

        // Time.deltaTime : ���� �������� �Ϸ�Ǵ� ������ �ɸ� �ð��� �ǹ�.
        transform.position += direction * speed * Time.deltaTime;
    }
}
