USE [会员管理系统1.0]
GO

/****** Object:  Table [dbo].[员工]    Script Date: 2018/7/14 20:56:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[员工](
	[员工id] [char](5) NOT NULL,
	[姓名] [varchar](20) NOT NULL,
	[性别] [char](2) NOT NULL,
	[联系方式] [varchar](11) NOT NULL,
	[密码] [char](6) NOT NULL,
 CONSTRAINT [PK_员工] PRIMARY KEY CLUSTERED 
(
	[员工id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


