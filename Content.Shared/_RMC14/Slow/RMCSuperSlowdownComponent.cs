using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Slow;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class RMCSuperSlowdownComponent : Component
{
    [DataField, AutoNetworkedField]
    public TimeSpan ExpiresAt;
}
