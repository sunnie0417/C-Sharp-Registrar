using System;
using System.Runtime.CompilerServices;

namespace Registrar.Models;

public class CourseCheckBox
{
    public string Text { get; set; } = "";
    public int Value { get; set; }
    public int Hours { get; set; } 
    public bool IsChecked { get; set; }
}
