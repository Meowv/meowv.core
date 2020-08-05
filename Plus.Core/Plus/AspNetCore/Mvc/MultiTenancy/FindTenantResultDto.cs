﻿using System;

namespace Plus.AspNetCore.Mvc.MultiTenancy
{
    [Serializable]
    public class FindTenantResultDto
    {
        public bool Success { get; set; }

        public Guid? TenantId { get; set; }

        public string Name { get; set; }
    }
}