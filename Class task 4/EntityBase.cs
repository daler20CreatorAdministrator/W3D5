// public abstract class EntityBase
// {
//     public int Id { get; set; }
//     public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
//     public DateTime? UpdatedAt { get; protected set; }
//     public bool IsActive { get; protected set; } = true;

//     public abstract void Validate();

//     public virtual void Deactivate()
//     {
//         IsActive = false;
//         UpdatedAt = DateTime.UtcNow;
//     }
// }
