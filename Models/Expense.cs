using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models;

public class Expense
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    [Required]
    public string? Description { get; set; }

    // public Expense(int id, decimal value, string description)
    // {
    //     Id = id;
    //     Value = value;
    //     Description = description;
    // }
}
