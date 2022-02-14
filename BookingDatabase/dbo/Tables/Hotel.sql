CREATE TABLE [dbo].[Hotel] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [HotelName] NVARCHAR (255) NOT NULL,
    [Location]  NVARCHAR (255) NOT NULL,
    [Rate]      NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ([Id] ASC)
);

