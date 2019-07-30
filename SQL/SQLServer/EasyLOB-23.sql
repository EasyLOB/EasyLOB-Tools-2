
/*

-- Activity -> EasyLOBActivity*

DROP INDEX IX_Activity_01 ON EasyLOBActivity

ALTER TABLE EasyLOBActivityRole DROP CONSTRAINT UN_Activity_01
DROP INDEX IX_ActivityRole_01 ON EasyLOBActivityRole

-- AuditTrail -> EasyLOBAuitTrail*

ALTER TABLE EasyLOBAuditTrailConfiguration DROP CONSTRAINT UN_AuditTrailConfiguration_01
DROP INDEX IX_AuditTrailConfiguration_01 ON EasyLOBAuditTrailConfiguration
DROP INDEX IX_AuditTrailConfiguration_02 ON EasyLOBAuditTrailConfiguration

DROP INDEX IX_AuditTrailLog_01 ON EasyLOBAuditTrailLog
DROP INDEX IX_AuditTrailLog_02 ON EasyLOBAuditTrailLog
DROP INDEX IX_AuditTrailLog_03 ON EasyLOBAuditTrailLog
DROP INDEX IX_AuditTrailLog_04 ON EasyLOBAuditTrailLog
DROP INDEX IX_AuditTrailLog_05 ON EasyLOBAuditTrailLog

*/

-- EasyLOBActivity

CREATE INDEX IX_EasyLOBActivity_Name ON EasyLOBActivity(Name)

ALTER TABLE EasyLOBActivityRole ADD CONSTRAINT
    FK_EasyLOBActivityRole_EasyLOBActivity FOREIGN KEY(ActivityId) REFERENCES EasyLOBActivity(Id) ON UPDATE CASCADE
CREATE INDEX IX_EasyLOBActivityRole_RoleName ON EasyLOBActivityRole(RoleName)

-- EasyLOBAuditTrail

ALTER TABLE EasyLOBAuditTrailConfiguration ADD CONSTRAINT
    UN_EasyLOBAuditTrailConfiguration UNIQUE (Domain, Entity)
CREATE INDEX IX_EasyLOBAuditTrailConfiguration_Domain ON EasyLOBAuditTrailConfiguration(Domain)
CREATE INDEX IX_EasyLOBAuditTrailConfiguration_Entity ON EasyLOBAuditTrailConfiguration(Entity)

CREATE INDEX IX_EasyLOBAuditTrailLog_LogDate ON EasyLOBAuditTrailLog(LogDate, LogTime)
CREATE INDEX IX_EasyLOBAuditTrailLog_LogUserName ON EasyLOBAuditTrailLog(LogUserName)
CREATE INDEX IX_EasyLOBAuditTrailLog_LogDomain ON EasyLOBAuditTrailLog(LogDomain)
CREATE INDEX IX_EasyLOBAuditTrailLog_LogEntity ON EasyLOBAuditTrailLog(LogEntity)
CREATE INDEX IX_EasyLOBAuditTrailLog_LogOperation ON EasyLOBAuditTrailLog(LogOperation)
