using System;
using System.Collections.Generic;

namespace webapiwithdockercompose.Models;

public partial class TbltrainingCourse
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int? Flag { get; set; }
}
