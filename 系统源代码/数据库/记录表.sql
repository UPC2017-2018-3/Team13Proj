USE [��Ա����ϵͳ1.0]
GO

/****** Object:  Table [dbo].[��¼��]    Script Date: 2018/7/14 20:56:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[��¼��](
	[ʱ��] [datetime] NOT NULL,
	[��Աid] [char](5) NOT NULL,
	[�¼�����] [varchar](10) NOT NULL,
	[��������] [int] NOT NULL,
 CONSTRAINT [PK_��¼��] PRIMARY KEY CLUSTERED 
(
	[ʱ��] ASC,
	[��Աid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[��¼��]  WITH CHECK ADD  CONSTRAINT [FK_��¼��_��Ա��] FOREIGN KEY([��Աid])
REFERENCES [dbo].[��Ա��] ([��Աid])
GO

ALTER TABLE [dbo].[��¼��] CHECK CONSTRAINT [FK_��¼��_��Ա��]
GO


