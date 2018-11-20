/****** Script for SelectTopNRows command from SSMS  ******/
SELECT tbl_payment_orders.payment_order_id, tbl_payment_orders.issue_dt, tbl_user.fname, tbl_user.lname
FROM     tbl_payment_orders INNER JOIN
                  tbl_salary ON tbl_payment_orders.salary_id = tbl_salary.salary_id INNER JOIN
                  tbl_user ON tbl_salary.salary_id = tbl_user.salary_id