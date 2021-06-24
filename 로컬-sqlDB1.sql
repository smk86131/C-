select indate as 접수일, total_price as 총결제금액, 
(select customer_t.name from customer_t where 
    customer_t.cust_id=receipt_t.cust_id) as 고객명,
(select staff_t.name from STAFF_T where 
    STAFF_T.STAFF_ID = receipt_t.STAFF_ID) as 담당자
from receipt_t;

select repair as 수리항목, price as 수리비 from repair_item_t 
    where car_id = 
    (select customer_t.cust_id from customer_t
    where customer_t.name='박고객');