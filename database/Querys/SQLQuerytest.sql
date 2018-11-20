select user_id as actualvalue, fname+' '+lname as displayvalue, int_user_type_id
from tbl_user
where int_user_type_id = 1

select count(hours)
from tbl_timesheet
where user_id = 2 and timesheet_dt between 1/1/2018 and 31/1/2018
