USE [会员管理系统1.0]
GO

/****** Object:  Table [dbo].[会员表]    Script Date: 2018/7/14 20:56:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[会员表](
	[会员id] [char](5) NOT NULL,
	[姓名] [varchar](20) NOT NULL,
	[性别] [char](2) NOT NULL,
	[联系方式] [varchar](11) NOT NULL,
	[剩余积分] [int] NOT NULL,
 CONSTRAINT [PK_会员表] PRIMARY KEY CLUSTERED 
(
	[会员id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


