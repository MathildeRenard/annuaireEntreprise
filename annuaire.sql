CREATE TABLE SITE(
   id_site VARCHAR(50),
   name_site VARCHAR(50),
   PRIMARY KEY(id_site)
);

CREATE TABLE SERVICE(
   id_service VARCHAR(50),
   name_service VARCHAR(50),
   id_site VARCHAR(50) NOT NULL,
   PRIMARY KEY(id_service),
   FOREIGN KEY(id_site) REFERENCES SITE(id_site)
);

CREATE TABLE ROLE(
   id_role VARCHAR(50),
   role_name VARCHAR(50),
   PRIMARY KEY(id_role)
);

CREATE TABLE PERSON(
   id_employee INT,
   firstname VARCHAR(50),
   lastname VARCHAR(50),
   phone INT,
   mobile_phone INT,
   mail VARCHAR(50),
   password VARCHAR(50),
   id_role VARCHAR(50) NOT NULL,
   id_service VARCHAR(50) NOT NULL,
   id_site VARCHAR(50) NOT NULL,
   PRIMARY KEY(id_employee),
   FOREIGN KEY(id_role) REFERENCES ROLE(id_role),
   FOREIGN KEY(id_service) REFERENCES SERVICE(id_service),
   FOREIGN KEY(id_site) REFERENCES SITE(id_site)
);