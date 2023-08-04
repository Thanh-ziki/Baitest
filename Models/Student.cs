using System.ComponentModel.DataAnnotations;
namespace BaiTesst.Models;
public class Student
{
    [Key]
    public string Id {get; set;}
    public string Name {Get; set;}
}