using UnityEngine;
using Cinemachine;
 

[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")]
public class LockCameraY : CinemachineExtension
{
    [Tooltip("Lock the camera's Y position to this value")]
    public float m_yPosition = 0;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_yPosition;
            state.RawPosition = pos;
        }
    }
}
