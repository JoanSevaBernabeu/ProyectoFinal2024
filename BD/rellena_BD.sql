INSERT INTO medico(dni,nombre,apellidos,email,contrasenya,numContacto)
VALUES
('49778698G','Debora','Florin Crespo','deboraf@medico.es','03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4','620300301'),
('78058395H','Claudia','Perez Anton','claudiap@medico.es','03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4','688493860'),
('58583045Z','Alejandro','Cuesta Cuevas','alejandroc@medico.es','88D4266FD4E6338D13B845FCF289579D209C897823B9217DA3E161936F031589','680427904');

INSERT INTO habitacion(numHabitacion,numCamasTotales,numCamasOcu)
VALUES
('001',2,1),
('002',1,1),
('003',3,2);

INSERT INTO medicamento 
VALUES 
('0876','ibuprofeno',100,8),
('0877','paracetamol',20,8);

INSERT INTO tratamiento
VALUES
('tratamiento1','Tos seca','Dar la vuelta al paciente, estando boca abajo, y dar unas palmaditas en la espalda','0876'),
('tratamiento2','Fiebre','Dar el medicamento, y dejar al paciente en reposo','0876'),
('tratamiento3','Diarrea','Hecho de hacer la kk liquida','0877');

INSERT INTO paciente(sip,nombre,apellidos,numContacto,nacimiento,tratamiento)
VALUES
('03670720','Goku','Hernandez Perez','688269982','1997','tratamiento1'),
('04017509','David','Lopez Moreno','690574075','1980','tratamiento2'),
('02847304','Monica','Rubio Sanz','620125982','1973','tratamiento3');

INSERT INTO trata
VALUES
('49778698G','03670720'),('78058395H','03670720'),('58583045Z','03670720'),
('49778698G','04017509'),('78058395H','04017509'),('58583045Z','04017509'),
('49778698G','02847304'),('78058395H','02847304'),('58583045Z','02847304');


select * from medico;
select * from habitacion;
select * from medicamento;
select * from tratamiento;
select * from paciente;
select * from trata;

select * from habitacion where numHabitacion = '002';
