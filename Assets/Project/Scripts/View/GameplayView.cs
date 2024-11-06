using Assets.Project.Scripts.Infrastructure.EventBuss;
using Assets.Project.Scripts.Infsrastrucrure.EventBus.EventHandlers;
using UnityEngine;

public class GameplayView : MonoBehaviour
{
    [SerializeField] private IEventBus eventBus;

    [SerializeField] public float CursorStep;
    public void UpCursorButton_OnClick()
    {
        eventBus.RaiseEvent<ICursorPositionDeltaChangedHandler>(h => h.CursorChangedHandler(new Vector2(0, CursorStep)));
    }

    public void DownCursorButton_OnClick()
    {
        eventBus.RaiseEvent<ICursorPositionDeltaChangedHandler>(h => h.CursorChangedHandler(new Vector2(0, -CursorStep)));
    }
}
