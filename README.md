cp1:
------
   创建数据库，脚本如下 ： </br>

```
create database MyFavorRepos

Create table tbl_Left
( 
   id int identity,</br>
   RepositoryName_Left nvarchar(max),
   RepositoryLink_Left nvarchar(max)
)



Create table tbl_Right</br>
(
   id int identity,</br>
   RepositoryName_Right nvarchar(max),
   RepositoryLink_Right nvarchar(max)
)
```
