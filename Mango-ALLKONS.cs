Mango -> ALLKONS ธรรมสรณ์ 23Aug  /   /// Office mate
Open API json

-องค์กรและการจัดการ

-Register
-Token

1.ส่งใบขอราคา Mango -> ALLKONS
2.รับ Compare ที ่WIN Viewอย่างเดียว  Mango <- ALLKONS 
3.ส่ง PO ที่อนุมัติไป Mango -> ALLKONS



NEXT Step Confirm flow

29/10/2024
==========Standard==========
-Win ได้หลาย Vendor พร้อมกัน



==========Partner==========
-Select Partner ได้ทีละเจ้า เลือกหลายเจ้าในใบเดียวไม่ได้

006   16,000,000
-
-
013   2,805895.74
-
-
 
014  1,600,000
-

005   1,800,000
-

2780 ต้าน
2765 รับ

win_item po_material_price
{
    "TaxId": "1234567891011",
    "CompanyName": "AAA1",
    "JuristicPerson": true,
    "Address": "112/44",
    "SubDistrictId": 127,
    "DistrictId": 37,
    "ProvinceId": 111,
    "PostalCode": "10400",
    
}

{
    "status": 200,
    "message": "Success",
    "data": {
        "CompanyId":"1dcdaa45-f3db-4384-95d3-c06b95ba1873"
    }
}



- กรณีไม่มีไฟล์ Form มีปัญหา
- เส้นเรียกเอกสาร PO Read เอกสาร po 
- ถ้าไม่ได้ Form  ให้ยิง Get มา ไม่เกิน7วัน

mango confrim 10 may