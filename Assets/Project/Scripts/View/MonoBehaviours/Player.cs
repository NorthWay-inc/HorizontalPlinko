using Assets.Project.Scripts.Infsrastrucrure.EventBus.EventHandlers;
using UnityEngine;

public class Player : MonoBehaviour, ICursorPositionDeltaChangedHandler
{
    private Vector2 _cursorPosition;

    public void CursorChangedHandler(Vector2 delta)
    {
        _cursorPosition += delta;
    }
}
