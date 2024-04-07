Написать программу на языке C#, которая получает данные с сервиса погоды (Forecast.xml), сохраняет в БД и отображает их.
Необходимо реализовать возможность выбора города и даты, при отображении.
Компоненты:
•	Приложение, умеющая получать и отображать данные метеосервиса.
•	База Данных, с полученными данными.
Адреса Метеосервиса, с разбивкой по городам:
•	http://www.yr.no/place/france/%c3%8Ele-de-France/Paris/forecast.xml
•	https://www.yr.no/place/Russia/Moscow/Moscow/forecast.xml
•	https://www.yr.no/place/Norway/Oslo/Oslo/Oslo/forecast.xml
•	https://www.yr.no/place/Germany/Berlin/Berlin/forecast.xml
В приложении имеется файл – “CitiesForecast.db” -  SqLite ‘экземпляр БД, с уже созданными таблицами.
Описание Таблиц БД:
Cities:
	"Id"			INTEGER,
	"Name"		TEXT,
	"Country"		TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
Forecast:
	"Id"			INTEGER,
	"CityId"			INTEGER,
	"DateFrom"		TEXT,
	"DateTo"		TEXT,
	"Temperature"		INTEGER,
	"Pressure"		INTEGER,
	FOREIGN KEY("CityId") REFERENCES "Cities"("Id") ON UPDATE CASCADE,
	PRIMARY KEY("Id" AUTOINCREMENT)
