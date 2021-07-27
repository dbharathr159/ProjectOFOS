create procedure sp_GetMenuByMenuId(@MenuId int)
as
begin
select *from Menu where MenuId=@MenuId
end
exec sp_GetMenuByMenuId 6