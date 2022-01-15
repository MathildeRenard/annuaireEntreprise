CREATE TABLE SITE(
   id_site INT NOT NULL AUTO_INCREMENT,
   name_site VARCHAR(50),
   PRIMARY KEY(id_site)
);

CREATE TABLE SERVICE(
   id_service INT NOT NULL AUTO_INCREMENT,
   name_service VARCHAR(50),
   PRIMARY KEY(id_service)
);


CREATE TABLE PERSON(
   id_person INT NOT NULL AUTO_INCREMENT,
   firstname VARCHAR(50),
   lastname VARCHAR(50),
   phone INT,
   mobile_phone INT,
   mail VARCHAR(50),
   password VARCHAR(50),
   id_site INT,
   id_service INT,
   PRIMARY KEY(id_person),
   FOREIGN KEY(id_service) REFERENCES SERVICE(id_service),
   FOREIGN KEY(id_site) REFERENCES SITE(id_site)
);