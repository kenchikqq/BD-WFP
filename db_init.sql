CREATE TABLE IF NOT EXISTS "Employee" (
  "Id" SERIAL PRIMARY KEY,
  "FullName" TEXT NOT NULL,
  "PhoneNumber" TEXT NOT NULL,
  "Email" TEXT NOT NULL
);

INSERT INTO "Employee" ("FullName","PhoneNumber","Email")
VALUES
('Иван Иванов','+79990000001','ivan@test.com'),
('Пётр Петров','+79990000002','petr@test.com');
