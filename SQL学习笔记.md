# 查询语句

1、查询数据表，``*``表示所有的列
> SELECT 列名,列名 FROM 表名

2、列出不同的值，即将该列重复的成员只出现一次
> SELECT DISTINCT 列名称 FROM 表名称

3、有条件地查询数据，列、运算符、值间无空格，非数值型值需要加上单引号，空值null使用（``WHERE 列名 IS NULL``）或（``WHERE列名 IS NOT NULL``）
> SELECT 列名,列名 FROM 表名称 WHERE 列 运算符 值

4、``AND``或``OR``可在``WHERE``中把多个条件结合起来
> SELECT 列名,列名 FROM 表名 WHERE 列名=某值 AND 列名=某值

5、对查出来的集进行排序，根据列名对查询出来的表进行排序，可跟在``WHERE``语句后面，可写多个``ORDER BY``
> SELECT 列名,列名 FROM 表名 ORDER BY 列名

### 高级部分

6、指定查询语句可以查到的行数，数字后使用PERCENT指定选取的百分比
（MySQL语法：``SELECT column_name(s) FROM table_name LIMIT number``）
（Oracle 语法：``SELECT column_name(s) FROM table_name WHERE ROWNUM <= number``）
> SELECT TOP 数字 列名,列名 FROM 表名

7、用于在WHERE字句中包含匹配查询使用，关键字部分使用``%``表示若干任意字符，``_``表示匹配1个任意字符，还可以使用``[]``匹配字符的方法。
> SELECT 列名,列名 FROM 表名 WHERE 列名 LIKE 关键字

8、可在WHERE中设置多个查找的值。可返回满足条件的多行。
> SELECT 列名,列名 FROM 表名 WHERE 列名 IN (值1, 值2,...)

9、选取介于两值之间的数据，SQL Server取值结果为 ``[值1，值2）``半开半闭区间，其他数据库取值范围有差异。在``BETWEEN``前加``NOT``显示范围之外的值。
> SELECT 列名,列名 FROM 表名 WHERE 列名 BETWEEN 值1 AND 值2

10、可以为表名称指定别名
> SELECT 列名,列名 FROM 表名 AS 别名
可以为列名称指定别名
> SELECT 列名 AS 别名 FROM 表名

以上修改别名不影响原列名、表名，eg：
```sql
SELECT po.OrderID, p.LastName, p.FirstName FROM Persons AS p, Product_Orders AS po WHERE p.LastName='Adams' AND p.FirstName='John'
```

11、连接查询，根据多个表中列之间的关系，查询数据。其他JOIN：
> SELECT 表名1.列名, 表名1.列名, 表名2.列名 FROM 表名1 INNER JOIN 表名2 ON 表名1.列名 = 表名2.列名 ORDER BY 表名1.列名

* ``JOIN``: 如果表中有至少一个匹配，则返回行。INNER JOIN 与 JOIN 是相同的。
* ``LEFT JOIN``: 即使右表中没有匹配，也从左表返回所有的行
* ``RIGHT JOIN``: 即使左表中没有匹配，也从右表返回所有的行
* ``FULL JOIN``: 只要其中一个表中存在匹配，就返回行

连接查询的一般实现形式
> SELECT 表名1.列名, 表名1.列名, 表名2.列名 FROM 表名1, 表名2 WHERE 表名1.Id_P = 表名2.Id_P

12、用于合并多个SELECT语句的结果集，将两个表中指定的列合并起来，并去掉重复的部分。注意两个column_name(s)的数量必须相同，table_name1的类型必须相似。还可以使用``UNION ALL``来保留重复的部分。
> SELECT column_name(s) FROM table_name1 UNION SELECT column_name(s) FROM table_name2




# 数据操作语句
1、给表中插入新的行，列名不写则全表插入。非数值型值需要单引号，列名不需要。
> INSERT INTO 表名 (列1, 列2,...) VALUES (值1, 值2,....)

2、更新表中的行，使用多个列名称=新值可以同时更新若干列
> UPDATE 表名称 SET 列名称 = 新值 WHERE 列名称 = 某值

3、删除表中指定的行，没有WHERE会删除所有的行
> DELETE FROM 表名称 WHERE 列名称 = 值

### 高级教程

4、从一个表里选取数据，然后把数据插入到另一个表中。常用语备份和存档。``IN``子句可用于向另一个数据库中拷贝表，可不写。在最后面也可加``WHERE``进行过滤需要的值。
> SELECT column_name(s) INTO new_table_name [IN externaldatabase] FROM old_tablename

5、用于创建数据库
> CREATE DATABASE database_name

6、用于创建数据库中的表
> CREATE TABLE 表名称
> (
> 列名称1 数据类型,
> 列名称2 数据类型,
> 列名称3 数据类型,
> ....
> )

eg：
```sql
CREATE TABLE Persons
(
Id_P int,
LastName nvarchar(255),
FirstName nvarchar(255),
Address nvarchar(255),
City nvarchar(255)
)
```

7、``Constraints``约束，用于限制加入表的数据类型，可以在创建表时规定约束，或在创建之后也可以。
* ``NOT NULL``: 不接受空值
* ``UNIQUE``: 唯一
* ``PRIMARY KEY``: 主键，不能有null值，每个表只能有一个主键列
* ``FOREIGN KEY``: 外部键，指向另一个表中的``PRIMARY KEY``，用于预防破坏表间连接的动作，也能防止非法数据插入外键列
* ``CHECK``: 检查，用于限制列中的值的范围
* ``DEFAULT``: 默认，用于约束向列中插入默认值，除普通参数外，也可以使用函数插入系统值如``GETDATE()``

创建时使用约束,eg：
```sql
CREATE TABLE Persons
(
Id_P int NOT NULL UNIQUE,
LastName i255) PRIMARY KEY,
FirstName i255) FOREIGN KEY REFERENCES i),
Address i255) DEFAULT 'i',
City nvarchar(255),
CONSTRAINT chk_Person CHECK (Id_P>0 AND City='Sandnes')
)
```

创建时定义并命名约束,eg：
```sql
CREATE TABLE Persons
(
Id_P int NOT NULL,
LastName nvarchar(255) NOT NULL,
FirstName nvarchar(255),
Address nvarchar(255),
City nvarchar(255),
CONSTRAINT uc_PersonID UNIQUE (Id_P,LastName),
CONSTRAINT pk_PersonID PRIMARY KEY (Id_P,LastName),
CONSTRAINT fk_PerOrders FOREIGN KEY (Id_P) REFERENCES Orders (Id_P)
)
```

为现有表增加约束,eg：
```sql
ALTER TABLE Persons
ADD UNIQUE (Id_P)
```
	
为现有表定义并命名约束,eg：
```sql
ALTER TABLE Persons
ADD CONSTRAINT uc_PersonID UNIQUE (Id_P,LastName)
```

撤销约束,eg：
```sql
ALTER TABLE Persons
DROP CONSTRAINT uc_PersonID
```

8、为表中的某一列创建索引，以便更加快速高效地查询数据。可使用``CREATE UNIQUE INDEX``创建唯一的索引，也可以降序（``DESC``）索引某列中的值，也可以索引多列。
> CREATE INDEX index_name ON table_name (column_name)

9、用于删除索引、表、数据库，eg：
> DROP INDEX table_name.index_name

删除索引,eg:
```sql
DROP INDEX table_name.index_name
```
删除表,eg:
```sql
DROP TABLE 表名称
```
删除数据库,eg:
```sql
DROP DATABASE 数据库名称
```

10、表中添加一列
> ALTER TABLE table_name ADD column_name datatype

表中删除一列
> ALTER TABLE table_name DROP COLUMN column_name

表中修改列类型
> ALTER TABLE table_name ALTER COLUMN column_name datatype

11、使用``IDENTITY``关键字来执行auto-increment（自动增量）任务，默认增量1，也可指定``IDENTITY(20,10)``为初始值20，增量10
> CREATE TABLE Persons
> (
> P_Id int PRIMARY KEY IDENTITY,
> LastName varchar(255) NOT NULL,
> FirstName varchar(255),
> Address varchar(255),
> City varchar(255)
> )

12、创建视图，视图中的字段就是来自一个或多个数据库中的真实的表中的字段。可以向视图中添加``SQL函数``、``WHERE``、``JOIN``语句、提交数据。
> CREATE VIEW view_name AS
> SELECT column_name(s)
> FROM table_name
> WHERE condition

创建视图，eg：
```sql
CREATE VIEW [Products Above Average Price] AS
SELECT ProductName,UnitPrice
FROM Products
WHERE UnitPrice>(SELECT AVG(UnitPrice) FROM Products)
```

更新视图，eg：
```sql
SQL CREATE OR REPLACE VIEW Syntax
CREATE OR REPLACE VIEW view_name AS
SELECT column_name(s)
FROM table_name
WHERE condition
```

撤销视图，eg：
```sql
SQL DROP VIEW Syntax
DROP VIEW view_name
```

13、SQL Server Date 函数
* ``GETDATE()``: 返回当前日期和时间
* ``DATEPART()``: 返回日期/时间的单独部分
* ``DATEADD()``: 在日期中添加或减去指定的时间间隔
* ``DATEDIFF()``: 返回两个日期之间的时间
* ``CONVERT()``: 用不同的格式显示日期/时间

14、``SQL ISNULL()``、``Oracle NVL()``、``MySQL IFNULL()``、``MySQL COALESCE()`` 函数
这些函数用于规定如何处理表中的NULL值，eg：
```sql
SELECT ProductName,UnitPrice*(UnitsInStock+ISNULL(UnitsOnOrder,0)) FROM Products  --值为null返回0
```




# 函数
1、返回某列的平均值
> SELECT AVG(OrderPrice) AS OrderAverage FROM Orders

2、返回某列的行数（不包括NULL值），``COUNT(*)``返回被选行数，``COUNT(DISTINCT column)`` 返回相异结果的数目
> SELECT COUNT(Customer) AS CustomerNilsen FROM Orders WHERE Customer='Carter'

3、返回在指定的域中第一个记录的值（SQLServer2000 不支持）
> SELECT FIRST(OrderPrice) AS FirstOrderPrice FROM Orders

4、返回在指定的域中最后一个记录的值（SQLServer2000 不支持）
> SELECT LAST(OrderPrice) AS LastOrderPrice FROM Orders

5、返回某列的最高值
> SELECT MAX(OrderPrice) AS LargestOrderPrice FROM Orders

6、返回某列的最低值
> SELECT MIN(OrderPrice) AS SmallestOrderPrice FROM Orders

7、返回某列的总和
> SELECT SUM(OrderPrice) AS OrderTotal FROM Orders

8、根据一个或多个列对结果集进行分组，而不是将列的所有成员运算为一个结果
> SELECT Customer,SUM(OrderPrice) FROM Orders GROUP BY Customer

9、用于控制结果输出部分，WHERE关键字无法与合计函数一起使用，WHERE关键字控制函数输入，``HAVING``控制函数输出。
> SELECT column_name, aggregate_function(column_name)
> FROM table_name
> WHERE column_name operator value
> GROUP BY column_name
> HAVING aggregate_icolumn_name) operator value

10、把字段的值转换为大写。
> SELECT UCASE(LastName) AS LastName,FirstName FROM Persons

11、把字段的值转换为小写。
> SELECT LCASE(LastName) AS LastName,FirstName FROM Persons

12、从文本字段中按长度提取字符。
> SELECT MID(City,1,3) AS SmallCity FROM Persons

13、得到每一行该列的内容长度。
> SELECT LEN(City) AS LengthOfCity FROM Persons

14、把数值字段舍入指定小数位数。
> SELECT ProductName, ROUND(UnitPrice,0) AS UnitPrice FROM Products

15、返回当前的日期和时间。SQL Server使用``getdate()``函数。
> SELECT ProductName, UnitPrice, Now() AS PerDate FROM Products

16、对字段的显示进行格式化。
> SELECT ProductName, UnitPrice, FORMAT(Now(),'YYYY-MM-DD') AS PerDate FROM Products

17、其他

|函数|描述|
|:---:|:---|
|BINARY_CHECKSUM|二进制校验和|
|CHECKSUM|校验和|
|CHECKSUM_AGG|校验和自动增益控制|
|STDEV(column)|某列的标准偏差|
|STDEVP(column)|某列总体的标准偏差|
|VAR(column)|某列非NULL值的方差|
|VARP(column)|某列所有非NULL值的总体方差|

18、获得一个表的所有字段名。
> Select Name FROM SysColumns Where id=Object_Id('表名')