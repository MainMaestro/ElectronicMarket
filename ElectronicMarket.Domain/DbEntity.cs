using System.ComponentModel.DataAnnotations;

namespace ElectronicMarket.Domain;

public abstract class DbEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
}
