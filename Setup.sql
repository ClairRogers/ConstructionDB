USE cconstructiondb;

 /* CREATE TABLE contractors (
   id VARCHAR(255) NOT NULL,
   name VARCHAR(150) NOT NULL,
   rate DECIMAL(5, 2) NOT NULL,
   PRIMARY KEY (id)
 );


 CREATE TABLE jobs (
   id VARCHAR(255) NOT NULL,
   title VARCHAR(155) NOT NULL,
   location VARCHAR(255) NOT NULL,
   budget int NOT NULL,
   PRIMARY KEY (id)
 ); */



/* 
 CREATE TABLE contractorjobs (
   id int NOT NULL AUTO_INCREMENT,
   contractorId VARCHAR(255) NOT NULL,
   jobId VARCHAR(255) NOT NULL,
   PRIMARY KEY (id),
   INDEX (jobId),

   FOREIGN KEY (contractorId) 
      REFERENCES contractors(id)
      ON DELETE CASCADE,

   FOREIGN KEY (jobId) 
      REFERENCES jobs(id)
      ON DELETE CASCADE
 ); */


 /* INSERT INTO contractors (id, name, rate)
 VALUES ("1C", "DMoney", 100.50),
      ("2C", "Jake", 25.88),
      ("3C", "Mark", 3.00);

INSERT INTO jobs (id, title, location, budget)
VALUES ("1J", "BCW Expansion", "123 Capital Blvd", 100000),
      ("2J", "Bank of America", "257 Fake St", 2900),
      ("3J", "Jamie's Burger Den", "895 Poison Ave", 100); */



/* INSERT INTO contractorjobs (contractorId, jobId)
VALUES ("1C", "1J"),
      ("1C", "2J"),
      ("1C", "3J"),
      ("2C", "1J"),
      ("3C", "3J"),
      ("1C", "1J"),
      ("2C", "1J"),
      ("3C", "3J"); */




/* DELETE FROM contractors
    WHERE id = "2C"; */

/* DELETE FROM contractorjobs
WHERE jobId = "3J" AND contractorId = "3C"; */

SELECT * FROM contractorjobs cj
INNER JOIN contractors c ON c.id = cj.contractorId
WHERE jobId = "1J";


