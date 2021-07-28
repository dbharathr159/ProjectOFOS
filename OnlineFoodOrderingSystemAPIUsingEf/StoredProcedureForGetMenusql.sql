create procedure sp_GetMenuByMenuId(@MenuId int)
as
begin
select *from Menu where MenuId=@MenuId
end