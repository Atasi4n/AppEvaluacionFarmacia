﻿using System;
using System.Collections.Generic;

namespace EvaluacionFarmaciaAPI.Models;

public partial class RequestType
{
    public int RequestTypeId { get; set; }

    public string RequestType1 { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
