using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CURSOR
{
    Hold,
    Attack
}

public class Mouse : MonoBehaviour
{
    [SerializeField] Texture2D[] mouseCursor;

    // Start is called before the first frame update
    void Start()
    {
        SetCursor(CURSOR.Hold);
    }

    // Update is called once per frame
    void Update()
    {
        Launch();
    }

    public void Launch()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SetCursor(CURSOR.Attack);
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            SetCursor(CURSOR.Hold);
        }
    }

    public void SetCursor(CURSOR cursorImage)
    {
        Cursor.SetCursor(mouseCursor[(int)cursorImage], Vector2.zero, CursorMode.ForceSoftware);
    }
}
