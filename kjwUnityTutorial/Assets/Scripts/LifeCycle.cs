using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        // Awake() �Լ��� ���� ������Ʈ�� ������ �� �� �ѹ��� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ �����϶��� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable() �Լ��� ���� ������Ʈ�� Ȱ��ȭ�� ������ ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start() �Լ��� ���� ������Ʈ�� ������ �� �� �ѹ��� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ ������ ���� ȣ����� �ʴ� �̺�Ʈ �Լ�.
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate() �Լ��� timeStep�� ������ ���� ����
        // ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("FixedUpdatate");
    }

    private void Update()
    {
        // Update() �Լ��� frame rate�� �ұ�Ģ�� ��������
        // �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate() �Լ��� Update() �Լ��� ȣ��� ��
        // �ѹ��� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable() �Լ��� ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy() �Լ��� ���� ������Ʈ�� �����Ǿ��� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("OnDestroy");
    }

}
