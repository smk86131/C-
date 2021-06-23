insert all
    into car_t values 
        (CAR_T_SEQ.NEXTVAL, '그랜저', '12가1234',
        '2500cc이하', '2020년식')
    into CUSTOMER_T values
        (CUSTOMER_T_SEQ.NEXTVAL, '홍길동', '0101234789',
        '19820520', CAR_T_SEQ.currval)
select * from dual;

insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,
    '4', '엔진오일 교환', '50000', CAR_T_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,
    '5', '부동액 교환', '50000', CAR_T_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,
    '6', '와이퍼 교환', '20000', CAR_T_SEQ.currval);
    
insert into RECEIPT_T values (RECEIPT_T_SEQ.NEXTVAL,
    CUSTOMER_T_SEQ.currval, CAR_T_SEQ.currval,
    '2021년6월23일',
    (select staff_t.staff_id
    from STAFF_T where staff_t.name='김우치'),'150000');