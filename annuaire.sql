CREATE TABLE SITE(
   id_site INT NOT NULL AUTO_INCREMENT,
   name_site VARCHAR(50),
   PRIMARY KEY(id_site)
);

CREATE TABLE SERVICE(
   id_service INT NOT NULL AUTO_INCREMENT,
   name_service VARCHAR(50),
   id_site INT,
   PRIMARY KEY(id_service),
   FOREIGN KEY(id_site) REFERENCES SITE(id_site)
);

CREATE TABLE ROLE(
   id_role INT NOT NULL AUTO_INCREMENT,
   role_name VARCHAR(50),
   PRIMARY KEY(id_role)
);

CREATE TABLE PERSON(
   id_person INT NOT NULL AUTO_INCREMENT,
   firstname VARCHAR(50),
   lastname VARCHAR(50),
   phone INT,
   mobile_phone INT,
   mail VARCHAR(50),
   password VARCHAR(50),
   id_role INT,
   id_service INT,
   PRIMARY KEY(id_person),
   FOREIGN KEY(id_role) REFERENCES ROLE(id_role),
   FOREIGN KEY(id_service) REFERENCES SERVICE(id_service)
);