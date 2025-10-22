using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutiine : MonoBehaviour
{
    SpriteRenderer mySR;
    Coroutine AA;
    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && AA == null)
           AA = StartCoroutine(change_color());
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StopCoroutine(AA);
            AA = null;
        }

    }

    IEnumerator change_color()
    {
        Debug.Log("���� ������ �����մϴ�");
        for (int i = 3; i > 0; i--)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(i);
        }
        yield return new WaitForSeconds(0.5f);

        int Count = 0;
        while (true)
        {
            mySR.color =
                new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            yield return new WaitForSeconds(1);
            Count++;
            if (Count == 3)
            {
                Debug.Log("3�� ������ �Ϸ��Ͽ����ϴ�");
                AA = null;
                yield break;
            }

        }
    }
}
