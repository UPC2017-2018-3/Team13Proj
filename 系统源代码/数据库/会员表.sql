USE [��Ա����ϵͳ1.0]
GO

/****** Object:  Table [dbo].[��Ա��]    Script Date: 2018/7/14 20:56:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[��Ա��](
	[��Աid] [char](5) NOT NULL,
	[����] [varchar](20) NOT NULL,
	[�Ա�] [char](2) NOT NULL,
	[��ϵ��ʽ] [varchar](11) NOT NULL,
	[ʣ�����] [int] NOT NULL,
 CONSTRAINT [PK_��Ա��] PRIMARY KEY CLUSTERED 
(
	[��Աid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


