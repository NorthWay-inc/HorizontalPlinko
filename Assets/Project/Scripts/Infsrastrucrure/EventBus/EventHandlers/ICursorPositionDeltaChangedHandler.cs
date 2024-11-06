using Assets.Project.Scripts.Infrastructure.EventBus.EventHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Project.Scripts.Infsrastrucrure.EventBus.EventHandlers
{
    internal interface ICursorPositionDeltaChangedHandler : IGlobalSubscriber
    {
        void CursorChangedHandler(Vector2 Delta);
    }
}
