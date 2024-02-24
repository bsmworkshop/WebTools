CREATE TABLE [dbo].[Material]
(
	[MaterialId]								INT					NOT NULL		IDENTITY(1000000,1),
	[Label]										NVARCHAR(100)		NOT NULL,
	[IsEquipment]								BIT					NOT NULL,
	CONSTRAINT [PK_Material] PRIMARY KEY (
		[MaterialId]
	)
)
GO

GRANT SELECT ON [dbo].[Material] TO [webtoolsapi]
GO