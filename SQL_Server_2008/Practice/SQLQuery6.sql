--update [THWMS].[dbo].[BASE_PART] set JIBENDANWEI='件' where JIBENDANWEI is NULL;
--update [THWMS].[dbo].[BASE_PART] set JIBENDANWEI='件' where JIBENDANWEI='';

--update [THWMS].[dbo].[BASE_PART] set TONGYONGJIAN='否' where TONGYONGJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set TONGYONGJIAN='否' where TONGYONGJIAN='';
--update [THWMS].[dbo].[BASE_PART] set KANBANJIAN='否' where KANBANJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set KANBANJIAN='否' where KANBANJIAN='';
--update [THWMS].[dbo].[BASE_PART] set PAIXUJIAN='否' where PAIXUJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set PAIXUJIAN='否' where PAIXUJIAN='';
--update [THWMS].[dbo].[BASE_PART] set SHIZHIJIAN='否' where SHIZHIJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set SHIZHIJIAN='否' where SHIZHIJIAN='';
--update [THWMS].[dbo].[BASE_PART] set XIANGJIAOJIAN='否' where XIANGJIAOJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set XIANGJIAOJIAN='否' where XIANGJIAOJIAN='';
--update [THWMS].[dbo].[BASE_PART] set YETIJIAN='否' where YETIJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set YETIJIAN='否' where YETIJIAN='';
--update [THWMS].[dbo].[BASE_PART] set CELLKIT='否' where CELLKIT is NULL;
--update [THWMS].[dbo].[BASE_PART] set CELLKIT='否' where CELLKIT='';
--update [THWMS].[dbo].[BASE_PART] set CHENGTAOJIAN='否' where CHENGTAOJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set CHENGTAOJIAN='否' where CHENGTAOJIAN='';
--update [THWMS].[dbo].[BASE_PART] set WAIXIEJIAN='否' where WAIXIEJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART] set WAIXIEJIAN='否' where WAIXIEJIAN='';
--update [THWMS].[dbo].[BASE_PART] set DAILICAIGOU='否' where DAILICAIGOU is NULL;
--update [THWMS].[dbo].[BASE_PART] set DAILICAIGOU='否' where DAILICAIGOU='';

--select * from [THWMS].[dbo].[BASE_PART]




--update [THWMS].[dbo].[BASE_PART_CUSTOMER] set LINGJIANHEGELV=0.00 where LINGJIANHEGELV is NULL;
--update [THWMS].[dbo].[BASE_PART_CUSTOMER] set DAOHUOJISHILV=0.00 where DAOHUOJISHILV is NULL;

--update [THWMS].[dbo].[BASE_PART_CUSTOMER] set CAOZUOYUAN='sys' where CAOZUOYUAN is NULL;
--update [THWMS].[dbo].[BASE_PART_CUSTOMER] set CAOZUOYUAN='sys' where CAOZUOYUAN='';

--update [THWMS].[dbo].[BASE_PART_CUSTOMER] set GENGXINSHIJIAN=getdate() where GENGXINSHIJIAN is NULL;
--update [THWMS].[dbo].[BASE_PART_CUSTOMER] set GENGXINSHIJIAN=getdate() where GENGXINSHIJIAN='';


select * from [THWMS].[dbo].[BASE_PART_CUSTOMER]