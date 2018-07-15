USE [会员管理系统1.0]
GO

CREATE TRIGGER shuaxin
ON 记录表
AFTER INSERT
AS
BEGIN

UPDATE dbo.会员表
SET dbo.会员表.剩余积分=b.积分增减
FROM (
SELECT 会员id,SUM(积分增减)积分增减
FROM dbo.记录表
GROUP BY 会员id)b
WHERE dbo.会员表.会员id=b.会员id
END