create procedure sp_GetMenuByMenuId(@Menuid int)
as
begin
select *from Menu where Menuid=@Menuid
end
exec sp_GetMenuByMenuId 6