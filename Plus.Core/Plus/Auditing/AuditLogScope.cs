﻿namespace Plus.Auditing
{
    public class AuditLogScope : IAuditLogScope
    {
        public AuditLogInfo Log { get; }

        public AuditLogScope(AuditLogInfo log)
        {
            Log = log;
        }
    }
}