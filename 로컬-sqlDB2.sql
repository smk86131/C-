create or REPLACE view receipt_view as
    select
        RECEIPT_ID as ����ID,
        indate as ������,
        total_price as �Ѱ����ݾ�,
        (select customer_t.name from customer_t where
        customer_t.cust_id = receipt_t.cust_id) as ����,
        (select staff_t.name from STAFF_T where
        STAFF_T.STAFF_ID = receipt_t.STAFF_ID) as �����,
        (slect car_t.num from car_t WHERE
        car_t.car_id = receipt_t.cust_id) as ������ȣ
    from receipt_t order by RECEIPT_ID desc;

select * from receipt_view where ����='������';
select * from receipt_view where ����ID=21;