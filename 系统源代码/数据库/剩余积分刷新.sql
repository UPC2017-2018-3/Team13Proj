USE [��Ա����ϵͳ1.0]
GO

CREATE TRIGGER shuaxin
ON ��¼��
AFTER INSERT
AS
BEGIN

UPDATE dbo.��Ա��
SET dbo.��Ա��.ʣ�����=b.��������
FROM (
SELECT ��Աid,SUM(��������)��������
FROM dbo.��¼��
GROUP BY ��Աid)b
WHERE dbo.��Ա��.��Աid=b.��Աid
END