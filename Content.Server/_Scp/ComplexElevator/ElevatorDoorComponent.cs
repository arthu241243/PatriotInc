using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared._Scp.ComplexElevator;

[RegisterComponent]
public sealed partial class ElevatorDoorComponent : Component
{
    [DataField]
    public string ElevatorId = "";

    [DataField]
    public string Floor = "";
}
