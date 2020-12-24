--Part 1
Id int
Name VARCHAR
EmployerId int

--Part 2
SELECT * FROM techjobs.Employers WHERE techjobs.Employers.Location = "St. Louis City";

--Part 3

SELECT Name, Description FROM Skills LEFT JOIN JobSkills ON Skills.Id = JobSkills.SkillId WHERE JobSkills.JobId IS NOT NULL ORDER BY Skills.Name ASC