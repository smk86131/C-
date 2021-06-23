-- 테이블 순서는 관계를 고려하여 한 번에 실행해도 에러가 발생하지 않게 정렬되었습니다.

-- car_t Table Create SQL
CREATE TABLE car_t
(
    car_id    INT             NOT NULL, 
    model     VARCHAR2(20)    NOT NULL, 
    num       VARCHAR2(20)    NOT NULL, 
    cc        VARCHAR2(20)    NOT NULL, 
    year      VARCHAR2(20)    NOT NULL, 
    CONSTRAINT PK_car_t PRIMARY KEY (car_id)
)
/

CREATE SEQUENCE car_t_SEQ
START WITH 1
INCREMENT BY 1;
/

-- customer_t Table Create SQL
CREATE TABLE customer_t
(
    cust_id    INT             NOT NULL, 
    name       VARCHAR2(20)    NOT NULL, 
    tel        VARCHAR2(20)    NOT NULL, 
    birth      VARCHAR2(20)    NOT NULL, 
    car_id     INT             NOT NULL, 
    CONSTRAINT PK_customer_t PRIMARY KEY (cust_id)
)
/

CREATE SEQUENCE customer_t_SEQ
START WITH 1
INCREMENT BY 1;
/

-- repair_item_t Table Create SQL
CREATE TABLE repair_item_t
(
    repair_item_id    INT             NOT NULL, 
    idx               INT             NOT NULL, 
    repair            VARCHAR2(20)    NOT NULL, 
    price             INT             NOT NULL, 
    car_id            INT             NOT NULL, 
    CONSTRAINT PK_repair_item_t PRIMARY KEY (repair_item_id)
)
/

CREATE SEQUENCE repair_item_t_SEQ
START WITH 1
INCREMENT BY 1;
/

-- staff_t Table Create SQL
CREATE TABLE staff_t
(
    staff_id    INT             NOT NULL, 
    tel         VARCHAR2(20)    NOT NULL, 
    adress      VARCHAR2(20)    NOT NULL, 
    birth       VARCHAR2(20)    NOT NULL, 
    rank        VARCHAR2(20)    NOT NULL, 
    workType    VARCHAR2(20)    NOT NULL, 
    salary      VARCHAR2(20)    NOT NULL, 
    CONSTRAINT PK_staff_t PRIMARY KEY (staff_id)
)
/

CREATE SEQUENCE staff_t_SEQ
START WITH 1
INCREMENT BY 1;
/

-- receipt_t Table Create SQL
CREATE TABLE receipt_t
(
    receipt_id        INT             NOT NULL, 
    cust_id           INT             NOT NULL, 
    repair_item_id    INT             NOT NULL, 
    indate            VARCHAR2(20)    NOT NULL, 
    staff_id          INT             NOT NULL, 
    total_price       INT             NOT NULL, 
    CONSTRAINT PK_receipt_t PRIMARY KEY (receipt_id)
)
/

CREATE SEQUENCE receipt_t_SEQ
START WITH 1
INCREMENT BY 1;
/


