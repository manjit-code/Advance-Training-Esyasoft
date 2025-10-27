using System;
using System.Collections.Generic;

namespace StudentDBFirst.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Email { get; set; } = null!;
}
