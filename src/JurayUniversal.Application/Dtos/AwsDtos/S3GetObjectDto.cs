﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurayUniversal.Application.Dtos.AwsDtos
{
    public class S3GetObjectDto
    {
        public string? Key { get; set; }
        public string? Bucket { get; set; }
    }
}
