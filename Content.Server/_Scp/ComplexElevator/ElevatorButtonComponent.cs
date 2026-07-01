using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared._Scp.ComplexElevator;

[RegisterComponent]
public sealed partial class ElevatorButtonComponent : Component
{
    [DataField]
    public string ElevatorId = string.Empty;

    [DataField]
    public ElevatorButtonType ButtonType = ElevatorButtonType.CallButton;

    [DataField]
    public string Floor = string.Empty;

}

public enum ElevatorButtonType
{
    CallButton,
    SendElevatorDown,
    SendElevatorUp,
}
