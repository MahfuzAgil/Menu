USE [Menu]
GO

/****** Object:  Table [dbo].[Reservation]    Script Date: 9/17/2018 8:30:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reservation](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[GuestName] [nvarchar](50) NOT NULL,
	[GuestPhoneNumber] [nchar](15) NOT NULL,
	[Date] [smalldatetime] NOT NULL
) ON [PRIMARY]
GO

