SELECT NAME FROM STUDENTS
WHERE MARKS > 75
ORDER BY SUBSTRING(name, len(name)-2, LEN(name)), ID;