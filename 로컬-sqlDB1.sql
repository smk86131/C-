select indate as ������, total_price as �Ѱ����ݾ�, 
(select customer_t.name from customer_t where 
    customer_t.cust_id=receipt_t.cust_id) as ����,
(select staff_t.name from STAFF_T where 
    STAFF_T.STAFF_ID = receipt_t.STAFF_ID) as �����
from receipt_t;

select repair as �����׸�, price as ������ from repair_item_t 
    where car_id = 
    (select customer_t.cust_id from customer_t
    where customer_t.name='�ڰ�');