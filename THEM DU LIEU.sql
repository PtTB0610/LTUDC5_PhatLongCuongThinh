
/*THEM DU LIEU*/
/*USER*/
EXEC SP_THEMDSUSER N'1','1','Admin'
EXEC SP_THEMDSUSER N'tuancuong','123456','Admin'
EXEC SP_THEMDSUSER N'hoalong','123456','Admin'
EXEC SP_THEMDSUSER N'tienphat', '123456','Admin'
EXEC SP_THEMDSUSER N'vantu', '123456','User'
EXEC SP_THEMDSUSER N'trunghieu', '123456','User'
EXEC SP_THEMDSUSER N'trungkien', '123456','User'
EXEC SP_THEMDSUSER N'tiensi', '123456','User'
EXEC SP_THEMDSUSER N'nguyena', '123456','User'
EXEC SP_THEMDSUSER N'nguyenb', '123456','User'
EXEC SP_THEMDSUSER N'lehoang', '123456','User'

/*CUSTOMER*/
EXEC sp_addCUSTOMER 'KH1', N'Tuan Cuong', N'tcuong@gmail.com', '0902078366', '10/18/1999', N'Thu Duc'
EXEC sp_addCUSTOMER 'KH2', N'Hoa Long', N'vlong@gmail.com', '0902128321', '10/25/1997', N'Dong Nai'
EXEC sp_addCUSTOMER 'KH3', N'Tien Phat', N'tphat@gmail.com', '0122078366', '5/5/1995', N'Quan 9'
EXEC sp_addCUSTOMER 'KH4', N'Van Tu', N'tutdc@gmail.com', '0908070360', '6/6/1996', N'Trang Bom'
EXEC sp_addCUSTOMER 'KH5', N'Trung Hieu', N'hieu98@gmail.com', '0902111111', '10/20/1998', N'Da Nang'
EXEC sp_addCUSTOMER 'KH6', N'Trung Kien', N'kien777@gmail.com', '0902012344', '10/25/1996', N'Tay Ninh'
EXEC sp_addCUSTOMER 'KH7', N'Tien Si', N'sides1998@gmail.com', '0902121212', '10/11/1999', N'Tay Nguyen'
EXEC sp_addCUSTOMER 'KH8', N'Nguyen A', N'toilaai@gmail.com', '0902785421', '12/12/1990', N'Phu My'
EXEC sp_addCUSTOMER 'KH9', N'Nguyen B', N'aimabiet@gmail.com', '09020323232', '7/7/1997', N'Tay Ninh'
EXEC sp_addCUSTOMER 'KH10', N'Le Hoang', N'hoangbadboy@gmail.com', '0902995886', '10/20/1998', N'Dong Nai'

/*EMPLOYEE*/
EXEC sp_ThemNhanVien 'NV1', N'Tuan Cuong', N'tcuong@gmail.com', '0902078366', '10/18/1999', N'Thu Duc'
EXEC sp_ThemNhanVien 'NV2', N'Hoa Long', N'vlong@gmail.com', '0902128321', '10/25/1997', N'Dong Nai'
EXEC sp_ThemNhanVien 'NV3', N'Tien Phat', N'tphat@gmail.com', '0122078366', '5/5/1995', N'Quan 9'
EXEC sp_ThemNhanVien 'NV4', N'Van Tu', N'tutdc@gmail.com', '0908070360', '6/6/1996', N'Trang Bom'
EXEC sp_ThemNhanVien 'NV5', N'Trung Hieu', N'hieu98@gmail.com', '0902111111', '10/20/1998', N'Da Nang'
EXEC sp_ThemNhanVien 'NV6', N'Trung Kien', N'kien777@gmail.com', '0902012344', '10/25/1996', N'Tay Ninh'
EXEC sp_ThemNhanVien 'NV7', N'Tien Si', N'sides1998@gmail.com', '0902121212', '10/11/1999', N'Tay Nguyen'
EXEC sp_ThemNhanVien 'NV8', N'Nguyen A', N'toilaai@gmail.com', '0902785421', '12/12/1990', N'Phu My'
EXEC sp_ThemNhanVien 'NV9', N'Nguyen B', N'aimabiet@gmail.com', '09020323232', '7/7/1997', N'Tay Ninh'
EXEC sp_ThemNhanVien 'NV10', N'Le Hoang', N'hoangbadboy@gmail.com', '0902995886', '10/20/1998', N'Dong Nai'

/*Payment*/

EXEC sp_addPAYMENT '1',N'Mua Tại Cửa Hàng',1
EXEC sp_addPAYMENT '2',N'Mua Online',0.9
EXEC sp_addPAYMENT '3',N'Trả góp',1.2

/*Supplier*/

exec SP_THEMSUPPLIER 1,'Dell','012121212','dell@gmail.com','HCM','active'
exec SP_THEMSUPPLIER 2,'Toshiba','012121212','toshiba@gmail.com','Da nang','active'
exec SP_THEMSUPPLIER 3,'Asus','012121212','asus@gmail.com','Ha noi','active'
exec SP_THEMSUPPLIER 4,'Apple','012121212','apple@gmail.com','HCM','active'
exec SP_THEMSUPPLIER 5,'Microsoft','012121212','soft@gmail.com','HCM','active'
exec SP_THEMSUPPLIER 6,'Xiaomi','012121212','mixao@gmail.com','Ha Noi','active'
exec SP_THEMSUPPLIER 7,'Oppo','012121212','oppo@gmail.com','Da Nang','active'
exec SP_THEMSUPPLIER 8,'Hoco','012121212','hoco@gmail.com','Vung tau','active'
exec SP_THEMSUPPLIER 9,'Amazon','012121212','amazon@gmail.com','My Tho','active'
exec SP_THEMSUPPLIER 10,'Alibaba','012121212','alibaba@gmail.com','ai cap','active'

/*Category*/

exec SP_THEMCATEGORY 1,'Laptop', 'active'
exec SP_THEMCATEGORY 2,'HeadPhone', 'active'
exec SP_THEMCATEGORY 3,'SmartPhone', 'active'
exec SP_THEMCATEGORY 4,'Smartwatch', 'active'
exec SP_THEMCATEGORY 5,'Tivi', 'active'
exec SP_THEMCATEGORY 6,'Other', 'active'

/*Product*/
exec SP_THEMDSPRODUCT '1','Laptop Toshiba HQ1',1,'',10000000,2,50,'i7 7700 Ram 8gb ssd 120gb hdd 1TB', 'active' 
exec SP_THEMDSPRODUCT '2','Asus Zenphone 5',3,'',10000000,3,100,'Chip snap 660 Ram 4gb', 'active' 
exec SP_THEMDSPRODUCT '3','Iphone X',3,'',12000000,4,50,'Chip Apple A11 Ram 3gb', 'active' 
exec SP_THEMDSPRODUCT '4','Asus Zenphone max pro m1',1,'',5900000,3,20,'Chip snap 660 Ram 4gb', 'active' 
exec SP_THEMDSPRODUCT '5','Toshiba LB 55',5,'',100000000,1,10,'Super Oled 4k internet 55 inch', 'active' 
exec SP_THEMDSPRODUCT '6','Asus Laptop nitro 5',1,'',19990000,3,5,'Chip i7 6700HQ ram 8gb 1050ti', 'active' 
exec SP_THEMDSPRODUCT '7','DELL alienware 17 R4',1,'',80000000,1,5,'Chip snap 8700HQ Ram 64gb 1080', 'active' 
exec SP_THEMDSPRODUCT '8','Asus Zenphone 6',1,'',10000000,2,5,'Chip snap 660 Ram 4gb', 'active' 
exec SP_THEMDSPRODUCT '9','Iphone 6s plus',3,'',5500000,4,50,'Chip Apple A9 Ram 2gb', 'active' 
exec SP_THEMDSPRODUCT '10','Iphone 7s plus',3,'',7000000,4,50,'Chip Apple A10 Ram 3gb', 'active' 

/*BILL*/
exec sp_ThemDSBILL 'BILL1','12/13/2018','KH1','1','NV1','1'
exec sp_ThemDSBILL 'BILL2','12/13/2018','KH2','2','NV2','1'
exec sp_ThemDSBILL 'BILL3','12/13/2018','KH3','3','NV3','1'
exec sp_ThemDSBILL 'BILL4','12/13/2018','KH4','4','NV4','1'
exec sp_ThemDSBILL 'BILL5','12/13/2018','KH5','5','NV5','1'
exec sp_ThemDSBILL 'BILL6','12/13/2018','KH6','6','NV6','1'
exec sp_ThemDSBILL 'BILL7','12/13/2018','KH7','7','NV7','1'
exec sp_ThemDSBILL 'BILL8','12/13/2018','KH8','8','NV8','1'
exec sp_ThemDSBILL 'BILL9','12/13/2018','KH9','9','NV9','1'
exec sp_ThemDSBILL 'BILL10','12/13/2018','KH10','10','NV10','1'


