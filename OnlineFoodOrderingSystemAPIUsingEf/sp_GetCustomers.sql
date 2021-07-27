create procedure sp_GetCustomers
as
begin
select FirstName,LastName,Email,Mobile from Customer
end
exec sp_GetCustomers