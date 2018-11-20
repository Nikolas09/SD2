select fname + lname as "Name", working_hours,hours, flat_amount,
salary_amount = working_hours*hourly_rate+flat_amount
from tbl_user, tbl_salary , tbl_timesheet
where tbl_user.user_id=tbl_salary.user_id and  tbl_user.user_id=tbl_timesheet.user_id;