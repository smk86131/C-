insert all
    into car_t values 
        (CAR_T_SEQ.NEXTVAL, '�׷���', '12��1234',
        '2500cc����', '2020���')
    into CUSTOMER_T values
        (CUSTOMER_T_SEQ.NEXTVAL, 'ȫ�浿', '0101234789',
        '19820520', CAR_T_SEQ.currval)
select * from dual;

insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,
    '4', '�������� ��ȯ', '50000', CAR_T_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,
    '5', '�ε��� ��ȯ', '50000', CAR_T_SEQ.currval);
insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL,
    '6', '������ ��ȯ', '20000', CAR_T_SEQ.currval);
    
insert into RECEIPT_T values (RECEIPT_T_SEQ.NEXTVAL,
    CUSTOMER_T_SEQ.currval, CAR_T_SEQ.currval,
    '2021��6��23��',
    (select staff_t.staff_id
    from STAFF_T where staff_t.name='���ġ'),'150000');