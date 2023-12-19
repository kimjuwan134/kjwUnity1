using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<Unit> listUnits;
    [SerializeField] Factory factory;

    float timer = 0;

    private void Start()
    {
        StartCoroutine(CreateRoutine());
    }

    public IEnumerator CreateRoutine()
    {
        while (true)
        {
            factory.CreateUnit(listUnits[Random.Range(0, listUnits.Count)]);

            // new WaitrForSeconds(5f) : Ư���� �ð����� �ڷ�ƾ�� ���.
            yield return new WaitForSeconds(5f);
        }
    }


}
