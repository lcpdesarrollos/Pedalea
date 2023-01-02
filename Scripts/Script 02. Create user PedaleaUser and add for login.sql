
GO
USE [master]

GO
CREATE LOGIN [PedaleaUser] 
WITH PASSWORD=N'Pedalea2023', 
DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], 
CHECK_EXPIRATION=OFF, 
CHECK_POLICY=OFF

GO
USE [Pedalea]

GO
CREATE USER [PedaleaUser] FOR LOGIN [PedaleaUser]

GO
USE [Pedalea]

GO
ALTER ROLE [db_owner] ADD MEMBER [PedaleaUser]





