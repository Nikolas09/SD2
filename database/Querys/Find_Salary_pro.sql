create procedure Find_Salary as
select fname + lname as "Name", working_hours,flat_amount,hours as "hours",
working_hours*hourly_rate + flat_amount as "Total Salary"
from tbl_user, tbl_salary, tbl_timesheet
where tbl_user.user_id=tbl_salary.user_id and tbl_user.user_id=tbl_timesheet.user_id
go