using UnityEngine;

public class cursorScript : MonoBehaviour
{
    public Texture2D cursor;

    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }
}
