CREATE ROLE [RSExecRole]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [RSExecRole] ADD MEMBER [NT SERVICE\SQLServerReportingServices];

