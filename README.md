To add data to databse use this query.
```
INSERT INTO Teachers (FirstName,LastName,Login,Password,Title) VALUES ('Pablo','Escobar','pabloecobal@gmail.com','!Qaz2wsx','Mgr')
INSERT INTO Teachers (FirstName,LastName,Login,Password,Title) VALUES ('Renie', 'Sheehy', 'rsheehy0@unicef.org', 'nkjOhkwWi8u','Mgr')
INSERT INTO Teachers (FirstName,LastName,Login,Password,Title) VALUES ('Lani', 'Beckey', 'lbeckey1@comcast.net', 'LkzP72','Mgr')
INSERT INTO Teachers (FirstName,LastName,Login,Password,Title) VALUES ('Doe', 'Aysik', 'daysik2@intel.com', '7ye42sMw','Mgr')
INSERT INTO Teachers (FirstName,LastName,Login,Password,Title) VALUES ('Catharina', 'Sheldrick', 'csheldrick3@webmd.com','!Qaz2wsx','Mgr')

INSERT INTO Students (FirstName,LastName,Login,Password,Semester) VALUES ('Antonino', 'Mockford', 'amockford4@cbslocal.com', '7lY63u2d',1)
INSERT INTO Students (FirstName,LastName,Login,Password,Semester) VALUES ('Camellia', 'Pesic', 'cpesic0@miibeian.gov.cn', 'ISuslr6DC3I',1)
INSERT INTO Students (FirstName,LastName,Login,Password,Semester) VALUES ('Adelaide', 'Ivakin', 'aivakin1@washington.edu', 'Db3RssZhG4',1)
INSERT INTO Students (FirstName,LastName,Login,Password,Semester) VALUES ('Sherill', 'Flowerdew', 'sflowerdew2@rakuten.co.jp', 'ITtvslS3p',1)
INSERT INTO Students (FirstName,LastName,Login,Password,Semester) VALUES ('Ashlee', 'Chatelot', 'achatelot3@unicef.org', 'AaizlQo6bif',1)

INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Mathematics',1);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Science',1);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Biology',2);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Chemistry',2);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Physics',2);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Economics',3);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Statistics',4);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Geometry',4);
INSERT INTO SchoolSubjects (Name,TeacherId) VALUES ('Mathematics',5);

INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (1,1);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (1,2);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (1,3);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (1,4);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (1,9);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (2,4);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (2,5);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (2,6);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (2,9);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (3,1);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (3,4);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (3,6);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (3,7);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (4,1);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (4,2);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (4,3);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (4,7);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (4,8);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (5,1);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (5,3);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (5,5);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (5,7);
INSERT INTO Schedules (StudentId,SchoolSubjectId) VALUES (5,8);

INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,1,1,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,1,1,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,1,1,2);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,1,2,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,1,2,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,1,2,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,4,2,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,4,2,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,4,2,2);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (1,4,2,3);

INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,1,3,2);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,1,3,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,5,3,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,5,3,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,2,4,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,2,4,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,3,4,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,3,4,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,5,5,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,5,5,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,2,5,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (2,2,5,2);

INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,2,6,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,2,6,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,2,6,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,2,6,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,2,6,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,3,6,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,3,6,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,3,6,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,3,6,2);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,3,6,2);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (3,3,6,2);

INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,3,7,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,3,7,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,3,7,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,3,7,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,7,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,7,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,7,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,7,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,5,8,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,5,8,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,5,8,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,5,8,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,8,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,8,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (4,4,8,5);



INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,1,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,5);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,4);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,3);
INSERT INTO Grades (TeacherId,StudentId,SchoolSubjectId,Grade) VALUES (5,2,9,3);
```
