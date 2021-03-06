
/*
-- DELETE

DELETE FROM EasyLOBActivityRole
DELETE FROM EasyLOBActivity
*/

/*
UPDATE EasyLOBActivityRole SET Operations = 'I' + Operations WHERE CHARINDEX('S', Operations) > 0
*/

/*
-- DROP

DROP TABLE EasyLOBActivityRole
DROP TABLE EasyLOBActivity
*/

CREATE TABLE EasyLOBActivity
(
	Id nvarchar(128) NOT NULL
	,Name nvarchar(256) NOT NULL
    ,CONSTRAINT PK_EasyLOBActivity PRIMARY KEY (Id)
)
CREATE INDEX IX_EasyLOBActivity_Name ON EasyLOBActivity(Name)

CREATE TABLE EasyLOBActivityRole
(
	ActivityId nvarchar(128) NOT NULL
	,RoleName nvarchar(256) NOT NULL
	,Operations varchar(256) NULL
    ,CONSTRAINT PK_EasyLOBActivityRole PRIMARY KEY (ActivityId, RoleName)
)
ALTER TABLE EasyLOBActivityRole ADD CONSTRAINT
    FK_EasyLOBActivityRole_EasyLOBActivity FOREIGN KEY(ActivityId) REFERENCES EasyLOBActivity(Id) ON UPDATE CASCADE
CREATE INDEX IX_EasyLOBActivityRole_RoleName ON EasyLOBActivityRole(RoleName)
