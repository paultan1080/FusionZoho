﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FusionZoho.API.Data.Models;

public partial class WebJob
{
    public long WebJobId { get; set; }

    public string FusionZohoJob { get; set; }

    public byte Status { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateCompleted { get; set; }

    public string Exception { get; set; }
}