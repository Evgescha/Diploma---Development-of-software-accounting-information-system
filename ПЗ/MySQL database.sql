DROP DATABASE IF EXISTS `SoftareAccounting`;
CREATE DATABASE IF NOT EXISTS `SoftareAccounting`;
USE `SoftareAccounting`;


DROP TABLE IF EXISTS `Producer`;
CREATE TABLE `Producer` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `producer` VARCHAR(255), 
  PRIMARY KEY (`ID`), 
  INDEX (`producer`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `Producer` (`ID`, `producer`) VALUES (1, 'Adobe');
INSERT INTO `Producer` (`ID`, `producer`) VALUES (2, 'Acrobat');
INSERT INTO `Producer` (`ID`, `producer`) VALUES (3, 'Nvidea');
INSERT INTO `Producer` (`ID`, `producer`) VALUES (4, 'NONE');
INSERT INTO `Producer` (`ID`, `producer`) VALUES (5, 'Sony');
INSERT INTO `Producer` (`ID`, `producer`) VALUES (6, 'Bolide');
INSERT INTO `Producer` (`ID`, `producer`) VALUES (7, 'Microsoft');


DROP TABLE IF EXISTS `Type`;
CREATE TABLE `Type` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `type` VARCHAR(255), 
  PRIMARY KEY (`ID`), 
  INDEX (`type`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `Type` (`ID`, `type`) VALUES (1, 'Офисное');
INSERT INTO `Type` (`ID`, `type`) VALUES (2, 'Прикладное');
INSERT INTO `Type` (`ID`, `type`) VALUES (3, 'Системное');
INSERT INTO `Type` (`ID`, `type`) VALUES (4, 'Браузеры');
INSERT INTO `Type` (`ID`, `type`) VALUES (5, 'Не определен');
# 5 records


DROP TABLE IF EXISTS `Software`;
CREATE TABLE `Software` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `name` VARCHAR(255), 
  `version` VARCHAR(255), 
  `producer` INTEGER, 
  `type` INTEGER, 
  `aproximate_size_mb` VARCHAR(255), 
  PRIMARY KEY (`ID`),
  FOREIGN KEY (`producer`) REFERENCES `Producer`(`ID`),
  FOREIGN KEY (`type`) REFERENCES `Type`(`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `Software` (`ID`, `name`, `version`, `producer`, `type`, `aproximate_size_mb`) VALUES (1, 'Photoshop', '2021.02', 1, 2, '1,5 ГБ');
INSERT INTO `Software` (`ID`, `name`, `version`, `producer`, `type`, `aproximate_size_mb`) VALUES (2, 'Word', '2016', 7, 1, '300 МБ');
INSERT INTO `Software` (`ID`, `name`, `version`, `producer`, `type`, `aproximate_size_mb`) VALUES (3, 'Excel', '2016', 7, 1, '200 МБ');
INSERT INTO `Software` (`ID`, `name`, `version`, `producer`, `type`, `aproximate_size_mb`) VALUES (4, 'Access', '2016', 7, 1, '200 МБ');
INSERT INTO `Software` (`ID`, `name`, `version`, `producer`, `type`, `aproximate_size_mb`) VALUES (5, 'Visual Studio 2013', '2013', 7, 2, '20ГБ');
INSERT INTO `Software` (`ID`, `name`, `version`, `producer`, `type`, `aproximate_size_mb`) VALUES (6, 'Eclipse', '9.0.13', 4, 2, '3 ГБ');
# 6 records


DROP TABLE IF EXISTS `HDD`;
CREATE TABLE `HDD` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `hdd` VARCHAR(255), 
  INDEX (`hdd`), 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `HDD` (`ID`, `hdd`) VALUES (1, 'SEAGATE');
INSERT INTO `HDD` (`ID`, `hdd`) VALUES (2, 'WESTERN DIGITAL (WD)');
INSERT INTO `HDD` (`ID`, `hdd`) VALUES (3, 'TOSHIBA');
INSERT INTO `HDD` (`ID`, `hdd`) VALUES (4, 'HITACHI');
INSERT INTO `HDD` (`ID`, `hdd`) VALUES (5, 'SAMSUNG');
# 5 records


DROP TABLE IF EXISTS `Processor`;
CREATE TABLE `Processor` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `processor` VARCHAR(255), 
  PRIMARY KEY (`ID`), 
  INDEX (`processor`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `Processor` (`ID`, `processor`) VALUES (1, '1 Ghz');
INSERT INTO `Processor` (`ID`, `processor`) VALUES (2, '1,9 Ghz');
INSERT INTO `Processor` (`ID`, `processor`) VALUES (3, '2 Ghz');
INSERT INTO `Processor` (`ID`, `processor`) VALUES (4, '3 Ghz');
INSERT INTO `Processor` (`ID`, `processor`) VALUES (5, '3.5 Ghz');
INSERT INTO `Processor` (`ID`, `processor`) VALUES (6, '4 Ghz');
# 6 records


DROP TABLE IF EXISTS `Videocard`;
CREATE TABLE `Videocard` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `videocard` VARCHAR(255), 
  PRIMARY KEY (`ID`), 
  INDEX (`videocard`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `Videocard` (`ID`, `videocard`) VALUES (1, 'Gigabyte GeForce GT 710');
INSERT INTO `Videocard` (`ID`, `videocard`) VALUES (2, 'GIGABYTE GeForce GT 1030 Low');
INSERT INTO `Videocard` (`ID`, `videocard`) VALUES (3, 'GIGABYTE GeForce GT 710 2GB (GV-N710D5-2GIL)');
INSERT INTO `Videocard` (`ID`, `videocard`) VALUES (4, 'MSI GeForce GTX 1650 D6');
INSERT INTO `Videocard` (`ID`, `videocard`) VALUES (5, 'MSI GeForce GTX 1650 D6 VENTUS XS');
INSERT INTO `Videocard` (`ID`, `videocard`) VALUES (8, 'ZOTAC GeForce GT 730');
# 6 records


DROP TABLE IF EXISTS `Computer`;
CREATE TABLE `Computer` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `name` VARCHAR(255), 
  `ip_adres` VARCHAR(255), 
  `location` VARCHAR(255), 
  `processor` INTEGER, 
  `ram_memory` VARCHAR(255), 
  `videocard` INTEGER, 
  `videocard_memory` VARCHAR(255), 
  `hdd` INTEGER, 
  `hdd_size` VARCHAR(255), 
  PRIMARY KEY (`ID`),
  FOREIGN KEY (`processor`) REFERENCES `Processor`(`ID`),
  FOREIGN KEY (`videocard`) REFERENCES `Videocard`(`ID`),
  FOREIGN KEY (`hdd`) REFERENCES `HDD`(`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `Computer` (`ID`, `name`, `ip_adres`, `location`, `processor`, `ram_memory`, `videocard`, `videocard_memory`, `hdd`, `hdd_size`) VALUES (1, 'ПК1', '192168000001', 'Кабинет 23', 3, '4 ГБ', 1, '512 МБ', 3, '512 ГБ');
INSERT INTO `Computer` (`ID`, `name`, `ip_adres`, `location`, `processor`, `ram_memory`, `videocard`, `videocard_memory`, `hdd`, `hdd_size`) VALUES (2, 'ПК2', '192168000002', 'Кабинет 23', 3, '8 ГБ', 3, '1 ГБ', 2, '512 ГБ');
INSERT INTO `Computer` (`ID`, `name`, `ip_adres`, `location`, `processor`, `ram_memory`, `videocard`, `videocard_memory`, `hdd`, `hdd_size`) VALUES (3, 'ПК3', '192168174215', 'Кабинет 445', 6, '16 ГБ', 8, '2 ГБ', 4, '1 ТБ');
# 3 records


DROP TABLE IF EXISTS `InstalledSoftare`;
CREATE TABLE `InstalledSoftare` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `computer` INTEGER, 
  `softare` INTEGER, 
  `date_installation` TIMESTAMP DEFAULT CURRENT_TIMESTAMP, 
  PRIMARY KEY (`ID`),
  FOREIGN KEY (`computer`) REFERENCES `Computer`(`ID`),
  FOREIGN KEY (`softare`) REFERENCES `Software`(`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (1, 1, 1, '2021-05-05 12:49:55');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (2, 1, 2, '2021-05-05 13:25:54');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (3, 1, 4, '2021-05-05 13:26:01');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (4, 2, 2, '2021-05-09 13:26:02');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (5, 2, 3, '2021-05-09 13:26:04');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (6, 2, 4, '2021-05-09 13:26:05');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (7, 3, 6, '2021-05-14 13:26:07');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (8, 3, 5, '2021-05-14 13:26:08');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (9, 3, 4, '2021-05-14 13:26:10');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (10, 3, 1, '2021-05-14 13:26:11');
INSERT INTO `InstalledSoftare` (`ID`, `computer`, `softare`, `date_installation`) VALUES (11, 3, 2, '2021-05-14 13:26:13');
# 11 records