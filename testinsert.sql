use sql7292929;
INSERT INTO `aday`(`aday_ad`, `aday_soyad`, `aday_ogrenim_durum`, `aday_TC`, `aday_tel`, `aday_saglikbelgesi`, `aday_adlibelge`, `aday_ehliyetsinif`) 
VALUES 
	('Akin', 'Balturk', 'Universite', 54152648795, 5348768976, 'var', 'var', 'A'),
	('Alihan', 'Sari', 'Universite', 5142697485, 5427654897, 'var', 'var', 'A'),
	('Emre', 'Coskun', 'Universite', 84576985421, 5342359768, 'var', 'var', 'B'),
	('Yahya', 'Gedik', 'Universite', 95841542572, 5459087065, 'var', 'var', 'A'),
	('Muhammet', 'Aykan', 'Universite', 84457545621, 5327458414, 'var', 'var', 'B'),
	('Remzi', 'Boztepe', 'Universite', 65412474851, 5441478495, 'var', 'var', 'B'),
	('Baris', 'Dogan', 'Universite', 44715425164, 5512689743, 'var', 'var', 'A'),
	('Tarik ', 'Ersoylu', 'Universite', 47851496235, 5348749561, 'var', 'var', 'A'),
	('Hatice', 'Sengul', 'Yuksek Lisans', 87451548963, 5414438972, 'var', 'var', 'B'),
	('Emine', 'Deniz', 'Yuksek Lisans', 65741248751, 5631789966, 'var', 'var', 'B'),
	('Halime', 'Denizci', 'Yuksek Lisans', 24157489985, 5411568745, 'var', 'var', 'B'),
	('Esra', 'Tatlici', 'Yuksek Lisans', 14874263658, 5447814958, 'var', 'var', 'A'),
	('Ayse', 'Bekci', 'Universite', 41784965774, 5356647141, 'var', 'var', 'B'),
	('Havva', 'Baltaci', 'Universite', 44518749854, 5517458696, 'var', 'var', 'A'),
	('Ezgi', 'Kaplan', 'Yuksek Lisans', 66584157843, 5541269568, 'var', 'var', 'B'),
	('Berfin', 'Vardar', 'Universite', 84514698432, 5426587495, 'var', 'var', 'A');
    
INSERT INTO `administrator` (`admin_ad`, `admin_soyad`, `admin_kadi`, `admin_pw`) 
VALUES 
	('Emre', 'Coskun', 'emre', 'emre123'),
	('Akin', 'Balturk', 'akin', 'akin123'),
	('Alihan', 'Sari', 'alihan', 'alihan123');

INSERT INTO `personel` (`personel_ad`, `personel_soyad`, `personel_kadi`, `personel_pw`) 
VALUES 
	('Hakan', 'Fil', 'hakan', 'hakan123'),
	('Asiye', 'Pars', 'asiye', 'asiye123'),
	('Furkan', 'Arkan', 'furkan', 'furkan123');
    
INSERT INTO `notTuru` (`notturu_id`, `notturu_ad`) 
VALUES 
	(1, 'esinav'),
	(2, 'dsinav');
    
INSERT INTO `notlar` (`notu`, `notturu_id`, `aday_id`) 
VALUES 
	(85, 1, 1),
	(80, 1, 2),
	(70, 1, 3),
	(84, 1, 4),
	(58, 1, 5),
	(40, 1, 6),
	(70, 1, 7),
	(50, 1, 8),
	(90, 1, 9),
	(100, 1, 10),
	(50, 1, 11),
	(15, 1, 12),
	(60, 1, 13),		
	(80, 1, 14),
	(60, 1, 15),	
	(100, 1, 16),
	(100, 2, 1),
	(50, 2, 2),
	(15, 2, 3),
	(40, 2, 4),
	(75, 2, 5),
	(90, 2, 6),	
	(54, 2, 7),	
	(55, 2, 8),
	(80, 2, 9),
	(20, 2, 10),
	(60, 2, 11),	
	(55, 2, 12),
	(90, 2, 13),
	(95, 2, 14),
	(100, 2, 15),
	(100, 2, 16);
    
INSERT INTO `odeme` (`aday_id`, `odeme_durum`, `odeme_tutar`) 
VALUES 
	(1, 'odendi', 1400),
	(2, 'odenmedi',1400),
	(3, 'odendi', 1400),
	(4, 'odendi', 1400),
	(5 , 'odenmedi', 1400),	
	(6, 'odendi', 1400),
	(10, 'odenmedi', 1400),
	(12, 'odendi', 1400),
	(13, 'odenmedi', 1400),	
	(14, 'odendi', 1400),
	(15, 'odendi', 1400),
	(16, 'odendi', 1400);