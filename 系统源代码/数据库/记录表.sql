USE [会员管理系统1.0]
GO

/****** Object:  Table [dbo].[记录表]    Script Date: 2018/7/14 20:56:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[记录表](
	[时间] [datetime] NOT NULL,
	[会员id] [char](5) NOT NULL,
	[事件类型] [varchar](10) NOT NULL,
	[积分增减] [int] NOT NULL,
 CONSTRAINT [PK_记录表] PRIMARY KEY CLUSTERED 
(
	[时间] ASC,
	[会员id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[记录表]  WITH CHECK ADD  CONSTRAINT [FK_记录表_会员表] FOREIGN KEY([会员id])
REFERENCES [dbo].[会员表] ([会员id])
GO

ALTER TABLE [dbo].[记录表] CHECK CONSTRAINT [FK_记录表_会员表]
GO


