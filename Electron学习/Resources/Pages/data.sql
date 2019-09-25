/*
 * @Author: mikey.zhaopeng 
 * @Date: 2018-06-18 09:40:29 
 * @Last Modified by: mikey.zhaopeng
 * @Last Modified time: 2018-06-18 10:39:28
 */
 /*
 * 培训类型
 */
 SELECT * from Attendances
INSERT into TrainTypes VALUES('在职培训','1111',0),
                                ('离职培训','1111',0),
                                ('企业公开培训','1111',0)
SELECT * FROM TrainTypes

/*
培训记录
*/

INSERT into Trains VALUES (1,'素质培训','2018-6-10','2018-6-10','第三会议室','老王','111111',0)

SELECT *FROM Trains

----试卷类型
INSERT into TestTypes VALUES('单选题','111',0),
                            ('多选题','111',0)

SELECT * FROM TestTypes

---题目

INSERT into Topics VALUES(1,'素质卷','A','111',0)
SELECT * FROM Topics

---成绩

INSERT into Grades VALUES (12,90,'优',0)
SELECT * from Grades