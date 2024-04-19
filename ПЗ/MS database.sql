DROP DATABASE "SoftareAccounting";
CREATE DATABASE "SoftareAccounting";
GO
USE "SoftareAccounting";
GO

CREATE TABLE "Producer" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "producer" VARCHAR(255), 
  PRIMARY KEY ("ID")
) 
GO

INSERT INTO "Producer" ("producer") VALUES ('Adobe');
INSERT INTO "Producer" ("producer") VALUES ('Acrobat');
INSERT INTO "Producer" ("producer") VALUES ('Nvidea');
INSERT INTO "Producer" ("producer") VALUES ('NONE');
INSERT INTO "Producer" ("producer") VALUES ('Sony');
INSERT INTO "Producer" ("producer") VALUES ('Bolide');
INSERT INTO "Producer" ("producer") VALUES ('Microsoft');


CREATE TABLE "Type" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "type" VARCHAR(255), 
  PRIMARY KEY ("ID")
)
GO

INSERT INTO "Type" ("type") VALUES ('Офисное');
INSERT INTO "Type" ("type") VALUES ('Прикладное');
INSERT INTO "Type" ("type") VALUES ('Системное');
INSERT INTO "Type" ("type") VALUES ('Браузеры');
INSERT INTO "Type" ("type") VALUES ('Не определен');



CREATE TABLE "Software" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "name" VARCHAR(255), 
  "version" VARCHAR(255), 
  "producer" INTEGER, 
  "type" INTEGER, 
  "aproximate_size_mb" VARCHAR(255), 
  PRIMARY KEY ("ID"),
  FOREIGN KEY ("producer") REFERENCES "Producer"("ID"),
  FOREIGN KEY ("type") REFERENCES "Type"("ID")
)
GO

INSERT INTO "Software" ("name", "version", "producer", "type", "aproximate_size_mb") VALUES ('Photoshop', '2021.02', 1, 2, '1,5 ГБ');
INSERT INTO "Software" ("name", "version", "producer", "type", "aproximate_size_mb") VALUES ('Word', '2016', 7, 1, '300 МБ');
INSERT INTO "Software" ("name", "version", "producer", "type", "aproximate_size_mb") VALUES ('Excel', '2016', 7, 1, '200 МБ');
INSERT INTO "Software" ("name", "version", "producer", "type", "aproximate_size_mb") VALUES ('Access', '2016', 7, 1, '200 МБ');
INSERT INTO "Software" ("name", "version", "producer", "type", "aproximate_size_mb") VALUES ('Visual Studio 2013', '2013', 7, 2, '20ГБ');
INSERT INTO "Software" ("name", "version", "producer", "type", "aproximate_size_mb") VALUES ('Eclipse', '9.0.13', 4, 2, '3 ГБ');



CREATE TABLE "HDD" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "hdd" VARCHAR(255), 
  PRIMARY KEY ("ID")
) 
GO

INSERT INTO "HDD" ("hdd") VALUES ('SEAGATE');
INSERT INTO "HDD" ("hdd") VALUES ('WESTERN DIGITAL (WD)');
INSERT INTO "HDD" ("hdd") VALUES ('TOSHIBA');
INSERT INTO "HDD" ("hdd") VALUES ('HITACHI');
INSERT INTO "HDD" ("hdd") VALUES ('SAMSUNG');



CREATE TABLE "Processor" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "processor" VARCHAR(255), 
  PRIMARY KEY ("ID")
) 
GO

INSERT INTO "Processor" ("processor") VALUES ('1 Ghz');
INSERT INTO "Processor" ("processor") VALUES ('1,9 Ghz');
INSERT INTO "Processor" ("processor") VALUES ('2 Ghz');
INSERT INTO "Processor" ("processor") VALUES ('3 Ghz');
INSERT INTO "Processor" ("processor") VALUES ('3.5 Ghz');
INSERT INTO "Processor" ("processor") VALUES ('4 Ghz');



CREATE TABLE "Videocard" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "videocard" VARCHAR(255), 
  PRIMARY KEY ("ID")
)
GO

INSERT INTO "Videocard" ("videocard") VALUES ('Gigabyte GeForce GT 710');
INSERT INTO "Videocard" ("videocard") VALUES ('GIGABYTE GeForce GT 1030 Low');
INSERT INTO "Videocard" ("videocard") VALUES ('GIGABYTE GeForce GT 710 2GB (GV-N710D5-2GIL)');
INSERT INTO "Videocard" ("videocard") VALUES ('MSI GeForce GTX 1650 D6');
INSERT INTO "Videocard" ("videocard") VALUES ('MSI GeForce GTX 1650 D6 VENTUS XS');
INSERT INTO "Videocard" ("videocard") VALUES ('ZOTAC GeForce GT 730');



CREATE TABLE "Computer" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "name" VARCHAR(255), 
  "ip_adres" VARCHAR(255), 
  "location" VARCHAR(255), 
  "processor" INTEGER, 
  "ram_memory" VARCHAR(255), 
  "videocard" INTEGER, 
  "videocard_memory" VARCHAR(255), 
  "hdd" INTEGER, 
  "hdd_size" VARCHAR(255), 
  PRIMARY KEY ("ID"),
  FOREIGN KEY ("processor") REFERENCES "Processor"("ID"),
  FOREIGN KEY ("videocard") REFERENCES "Videocard"("ID"),
  FOREIGN KEY ("hdd") REFERENCES "HDD"("ID")
) 
GO

INSERT INTO "Computer" ("name", "ip_adres", "location", "processor", "ram_memory", "videocard", "videocard_memory", "hdd", "hdd_size") VALUES ('ПК1', '192168000001', 'Кабинет 23', 3, '4 ГБ', 1, '512 МБ', 3, '512 ГБ');
INSERT INTO "Computer" ("name", "ip_adres", "location", "processor", "ram_memory", "videocard", "videocard_memory", "hdd", "hdd_size") VALUES ('ПК2', '192168000002', 'Кабинет 23', 3, '8 ГБ', 3, '1 ГБ', 2, '512 ГБ');
INSERT INTO "Computer" ("name", "ip_adres", "location", "processor", "ram_memory", "videocard", "videocard_memory", "hdd", "hdd_size") VALUES ('ПК3', '192168174215', 'Кабинет 445', 6, '16 ГБ', 3, '2 ГБ', 4, '1 ТБ');



CREATE TABLE "InstalledSoftare" (
  "ID" INTEGER NOT NULL IDENTITY(1,1), 
  "computer" INTEGER, 
  "softare" INTEGER, 
  "date_installation" DATETIME, 
  PRIMARY KEY ("ID"),
  FOREIGN KEY ("computer") REFERENCES "Computer"("ID"),
  FOREIGN KEY ("softare") REFERENCES "Software"("ID")
) 
GO

INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (1, 1, '2021-05-05T12:49:55');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (1, 2, '2021-05-05T13:25:54');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (1, 4, '2021-05-05T13:26:01');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (2, 2, '2021-05-09T13:26:02');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (2, 3, '2021-05-09T13:26:04');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (2, 4, '2021-05-09T13:26:05');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (3, 6, '2021-05-14T13:26:07');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (3, 5, '2021-05-14T13:26:08');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (3, 4, '2021-05-14T13:26:10');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (3, 1, '2021-05-14T13:26:11');
INSERT INTO "InstalledSoftare" ("computer", "softare", "date_installation") VALUES (3, 2, '2021-05-14T13:26:13');
GO