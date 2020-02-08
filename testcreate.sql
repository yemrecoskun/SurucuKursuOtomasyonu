create database if not exists sql7292929;
use sql7292929;
CREATE TABLE IF NOT EXISTS `aday` (
  `aday_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `aday_ad` VARCHAR(45) NOT NULL,
  `aday_soyad` VARCHAR(45) NOT NULL,
  `aday_ogrenim_durum` VARCHAR(45) NOT NULL,
  `aday_TC` BIGINT(11) NOT NULL,
  `aday_tel` BIGINT(11) NOT NULL,
  `aday_saglikbelgesi` VARCHAR(3) NOT NULL,
  `aday_adlibelge` VARCHAR(3) NOT NULL,
  `aday_ehliyetsinif` VARCHAR(11) NOT NULL
  );
  CREATE TABLE IF NOT EXISTS `administrator` (
  `admin_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `admin_ad` VARCHAR(45) NOT NULL,
  `admin_soyad` VARCHAR(45) NOT NULL,
  `admin_kadi` VARCHAR(45) NOT NULL,
  `admin_pw` VARCHAR(45) NOT NULL
  );
  CREATE TABLE IF NOT EXISTS `personel` (
  `personel_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `personel_ad` VARCHAR(45) NOT NULL,
  `personel_soyad` VARCHAR(45) NOT NULL,
  `personel_kadi` VARCHAR(45) NOT NULL,
  `personel_pw` VARCHAR(45) NOT NULL
  );
  CREATE TABLE IF NOT EXISTS `notTuru` (
  `notturu_id` INT NOT NULL PRIMARY KEY,
  `notturu_ad` VARCHAR(45) NOT NULL
  );
  CREATE TABLE IF NOT EXISTS `notlar` (
  `notu` INT NOT NULL,
  `notturu_id` INT NOT NULL,
  `aday_id` INT NOT NULL,
  CONSTRAINT `notturu_id` FOREIGN KEY (`notturu_id`) REFERENCES `notTuru` (`notturu_id`),
  CONSTRAINT `aday_id` FOREIGN KEY (`aday_id`) REFERENCES `aday` (`aday_id`)
  );
  CREATE TABLE IF NOT EXISTS `odeme` (
  `aday_id` INT NOT NULL,
  `odeme_durum` VARCHAR(10) NOT NULL,
  `odeme_tutar` INT NOT NULL,
  CONSTRAINT `odeme_aday_id` FOREIGN KEY (`aday_id`) REFERENCES `aday` (`aday_id`)
  );
  CREATE VIEW ehliyetview as Select a.aday_ad,n.aday_id,n.notturu_id,nt.notturu_ad,n.notu,ns.odeme_durum from notlar n 
  inner join notTuru nt ON n.notturu_id=nt.notturu_id 
  inner join aday a ON n.aday_id=a.aday_id
  inner join odeme ns ON ns.aday_id=a.aday_id ;
  CREATE VIEW NotlarGridView as Select a.aday_ad,n.aday_id,n.notturu_id,nt.notturu_ad,n.notu from notlar n 
  inner join notTuru nt ON n.notturu_id=nt.notturu_id 
  inner join aday a ON n.aday_id=a.aday_id;
 CREATE VIEW OdemeGridView as Select n.aday_id,a.aday_ad,n.odeme_durum,n.odeme_tutar from odeme n 
inner join aday a on n.aday_id=a.aday_id;