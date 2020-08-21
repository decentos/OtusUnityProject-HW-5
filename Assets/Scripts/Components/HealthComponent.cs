using Unity.Entities;

[GenerateAuthoringComponent]
public struct HealthComponent : IComponentData
{
    public float health;
}
