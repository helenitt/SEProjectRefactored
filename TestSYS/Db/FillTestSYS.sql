--TestData.sql
--This Oracle Script populates the database for the Test System
--Author Helen O'Brien

BEGIN;

INSERT INTO Students
(StudId,Sname,FName,DOB,Email,Passwd,RegDate,ExpDate,Status)
VALUES(0001,'NEESON','LIAM','21-Jan-1970','ln@gmail.com',123,'28-Jan-2016','28-Apr-2016','r');

INSERT INTO Students
(StudId,Sname,FName,DOB,Email,Passwd,RegDate,ExpDate,Status)
VALUES(0002,'RONAN','SAOISE','21-Jan-1980','lsr@gmail.com',234,'28-Jan-2016','28-Apr-2016','r');

INSERT INTO Students
(StudId,Sname,FName,DOB,Email,Passwd,RegDate,ExpDate,Status)
VALUES(0003,'BOOP','BETTY','21-Jan-1980','bb@gmail.com',345,'18-Feb-2016','28-Apr-2016','r');

INSERT INTO Students
(StudId,Sname,FName,DOB,Email,Passwd,RegDate,ExpDate,Status)
VALUES(0004,'BOOP','DOTTY','21-Jan-1980','bb@gmail.com',456,'28-Jan-2016','28-Apr-2016','r');

INSERT INTO Students
(StudId,Sname,FName,DOB,Email,Passwd,RegDate,ExpDate,Status)
VALUES(0005,'BYRNE','GABRIEL','10-Dec-1956','gb@gmail.com',567,'06-Mar-2015','06-Jun-2016','r');

INSERT INTO Students
(StudId,Sname,FName,DOB,Email,Passwd,RegDate,ExpDate,Status)
VALUES(0006,'OHARA','MAUREEN','19-Jul-1943','mo@gmail.com',678,'06-Feb-2016','06-May-2016','r');

COMMIT;

--LEVELS DATA

BEGIN;

INSERT INTO Levels
(LevelCode,Description)
VALUES('B','Basic');

INSERT INTO Levels
(LevelCode,Description)
VALUES('I','Intermediate');

INSERT INTO Levels
(LevelCode,Description)
VALUES('A','Advanced');

COMMIT;

--QUESTIONS DATA

BEGIN;

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0001','B','What is the capital of Ireland?','Rome','Paris','Dublin','London',3,'28-Jan-2016','11-MAR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0002','B','How high is Mount Brandon?','935','953','593','1055',2,'28-Jan-2016','04-APR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0003','B','What shines by day?','Stars','Moon','Street Light','Sun',4,'28-Jan-2016','11-MAR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0004','B','What animal barks?','Cat','Dog','Pig','Goat',2,'28-Jan-2016','12-Apr-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0005','B','With what do you crack a walnut?','Sledge Hammer','A Melon','Nut Cracker','Your hand',3,'28-Jan-2016','11-Mar-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0006','B','When is breakfast eaten?','Morning','Lunch','Afternoon','Evening',1,'28-Jan-2016','12-Apr-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0007','B','What is my favourite colour?','Pink','Green','Yellow','Blue',4,'28-Jan-2016','11-Mar-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0008','B','Which is the best programming language?','Java','PHP','SQL','JavaScript',3,'28-Jan-2016','28-Jan-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0009','B','Which is faster, a hare or a snail?','Hare','Snail','Rabbit','Cheetah',1,'28-Jan-2016','28-Jan-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0010','I','What is the capital of Ireland?','Rome','Paris','Dublin','London',3,'28-Jan-2016','11-MAR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0011','I','How high is Mount Brandon?','935','953','593','1055',2,'28-Jan-2016','04-APR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0012','I','What shines by day?','Stars','Moon','Street Light','Sun',4,'28-Jan-2016','11-MAR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0013','I','What animal barks?','Cat','Dog','Pig','Goat',2,'28-Jan-2016','12-Apr-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0014','I','With what do you crack a walnut?','Sledge Hammer','A Melon','Nut Cracker','Your hand',3,'28-Jan-2016','11-Mar-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0015','I','When is breakfast eaten?','Morning','Lunch','Afternoon','Evening',1,'28-Jan-2016','12-Apr-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0016','I','What is my favourite colour?','Pink','Green','Yellow','Blue',4,'28-Jan-2016','11-Mar-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0017','I','Which is the best programming language?','Java','PHP','SQL','JavaScript',3,'28-Jan-2016','28-Jan-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0018','I','Which is faster, a hare or a snail?','Hare','Snail','Rabbit','Cheetah',1,'28-Jan-2016','28-Jan-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0019','A','What is the capital of Ireland?','Rome','Paris','Dublin','London',3,'28-Jan-2016','11-MAR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0020','A','How high is Mount Brandon?','935','953','593','1055',2,'28-Jan-2016','04-APR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0021','A','What shines by day?','Stars','Moon','Street Light','Sun',4,'28-Jan-2016','11-MAR-16','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0022','A','What animal barks?','Cat','Dog','Pig','Goat',2,'28-Jan-2016','12-Apr-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0023','A','With what do you crack a walnut?','Sledge Hammer','A Melon','Nut Cracker','Your hand',3,'28-Jan-2016','11-Mar-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0024','A','When is breakfast eaten?','Morning','Lunch','Afternoon','Evening',1,'28-Jan-2016','12-Apr-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0025','A','What is my favourite colour?','Pink','Green','Yellow','Blue',4,'28-Jan-2016','11-Mar-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0026','A','Which is the best programming language?','Java','PHP','SQL','JavaScript',3,'28-Jan-2016','28-Jan-2016','a');

INSERT INTO Questions
(QuestId,LevelCode,Text,Ans1,Ans2,Ans3,Ans4,CorrectAns,QAdd,QAmd,Status)
VALUES('0027','A','Which is faster, a hare or a snail?','Hare','Snail','Rabbit','Cheetah',1,'28-Jan-2016','28-Jan-2016','a');

--Some sample lecturers
INSERT INTO Lecturers
VALUES(9001,'123','OBRIEN','HELEN');

INSERT INTO Lecturers
VALUES(9002,'234','WOODS','CATHERINE');

INSERT INTO Lecturers
VALUES(9003,'345','WALSH','JOHN');

COMMIT;
