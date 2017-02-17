----TestSYS.sql
----This Oracle Script builds the database for the Test System
----Author Helen O'Brien

BEGIN;

CREATE TABLE Students 
(
	  StudId numeric(4)
	, Email char(30)
	, Passwd char(8)
	, Sname char(20)
	, Fname char(20)
	, DOB date
	, [Status] char(1) CHECK([Status] = 'r' OR [Status] = 'd')
	, RegDate date
	, AmdDate date
	, ExpDate date
	, CONSTRAINT pk_Students PRIMARY KEY (StudId)
);

CREATE TABLE Lecturers 
(
	  LecId numeric(4)
	, Passwd char(8)
	, Sname char(20)
	, Fname char(20)
	, CONSTRAINT pk_Lecturers PRIMARY KEY (LecId)
);

CREATE TABLE Levels 
(
	  LevelCode char(1)
	, [Description] char(15)
	, CONSTRAINT pk_Levels PRIMARY KEY (LevelCode)
);

CREATE TABLE Questions
(
	  QuestId numeric(4)
	, LevelCode char(1)
	, [Text] char(100)
	, Ans1 char(50)
	, Ans2 char(50)
	, Ans3 char(50)
	, Ans4 char(50)
	, CorrectAns numeric(1)
	, QAdd date
	, QAmd date
	, [Status] char(1) CHECK([Status] = 'a' OR [Status] = 'd')
	, CONSTRAINT pk_Questions PRIMARY KEY (QuestId)
	, CONSTRAINT Fk_Levels_Q FOREIGN KEY (LevelCode) REFERENCES Levels(LevelCode)
);

CREATE TABLE Tests 
(
	  TestId numeric(4)
	, TestDate date
	, Score numeric(3)
	, StudId numeric(4)
	, LevelCode char(1)
	, CONSTRAINT pk_Tests PRIMARY KEY (TestId)
	, CONSTRAINT Fk_Students_T FOREIGN KEY (StudId) REFERENCES Students(StudId)
	, CONSTRAINT Fk_Levels_T FOREIGN KEY (LevelCode) REFERENCES Levels(LevelCode)
);

CREATE TABLE TestQuestions 
(
	  TestId numeric(4)
	, QuestId numeric(4)
	, AnsGiven numeric(1)
	, CONSTRAINT pk_TestQuestions PRIMARY KEY (TestId, QuestId)
	, CONSTRAINT fk_Tests_TQ FOREIGN KEY (TestId) REFERENCES Tests(TestId)
	, CONSTRAINT fk_Questions_TQ FOREIGN KEY (QuestId) REFERENCES Questions(QuestId)
);

COMMIT;
