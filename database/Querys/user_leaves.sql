SELECT COUNT(*) AS num_records, u.user_id, u.fname +' '+ u.lname as fullname
FROM     tbl_user_leaves as user_leave
left join tbl_user u on u.user_id = user_leave.user_id 
where is_sick_leave = 0 and is_payable =1
GROUP BY u.user_id, u.fname, u.lname