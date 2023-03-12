using UnityEngine;

public class CursorFollower : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTexture; // the cursor texture to use
    [SerializeField] private Vector2 cursorHotspot = Vector2.zero; // the hotspot of the cursor

    private void Start()
    {
        // set the cursor texture and hotspot
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
    }
}

