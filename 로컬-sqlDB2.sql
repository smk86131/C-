create or REPLACE view receipt_view as
    select
        RECEIPT_ID as 접수ID,
        indate as 접수일,
        total_price as 총결제금액,
        (select customer_t.name from customer_t where
        customer_t.cust_id = receipt_t.cust_id) as 고객명,
        (select staff_t.name from STAFF_T where
        STAFF_T.STAFF_ID = receipt_t.STAFF_ID) as 담당자,
        (slect car_t.num from car_t WHERE
        car_t.car_id = receipt_t.cust_id) as 차량번호
    from receipt_t order by RECEIPT_ID desc;

select * from receipt_view where 고객명='김유신';
select * from receipt_view where 접수ID=21;