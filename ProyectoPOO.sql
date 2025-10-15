-- Crear base de datos
create database Software_Academico;

-- Tabla maestra de Usuarios
create table Usuario (
    id_usuario int primary key identity(1,1),
    nombre varchar(100) not null,
    correo varchar(150) unique not null,
    contrasena varchar(255) not null,
    rol varchar(20) not null check (rol in ('estudiante','profesor','administrador')),
    fecha_registro datetime not null default getdate()
);

-- Tablas específicas
create table Estudiante (
    id_estudiante int primary key identity(1,1),
    id_usuario int not null,
    semestre varchar(50),
    fecha_ingreso date,
    foreign key (id_usuario) references Usuario(id_usuario)
);

create table Profesor (
    id_profesor int primary key identity(1,1),
    id_usuario int not null,
    especialidad varchar(100),
    fecha_contratacion date,
    foreign key (id_usuario) references Usuario(id_usuario)
);

create table Administrador (
    id_admin int primary key identity(1,1),
    id_usuario int not null,
    cargo varchar(100),
    foreign key (id_usuario) references Usuario(id_usuario)
);

-- Tabla de Asignatura
create table Asignatura (
    id_asignatura int primary key identity(1,1),
    nombre varchar(100) not null,
    creditos int not null check (creditos > 0),
    id_profesor int not null,
    foreign key (id_profesor) references Profesor(id_profesor)
);

-- Tabla de Calificaciones
create table Calificacion (
    id_calificacion int primary key identity(1,1),
    id_estudiante int not null,
    id_asignatura int not null,
    nota decimal(5,2) not null check (nota between 0 and 5),
    fecha_registro datetime not null default getdate(),
    foreign key (id_estudiante) references Estudiante(id_estudiante),
    foreign key (id_asignatura) references Asignatura(id_asignatura)
);

-- Tabla de Asistencia
create table Asistencia (
    id_asistencia int primary key identity(1,1),
    id_estudiante int not null,
    id_asignatura int not null,
    fecha date not null,
    estado varchar(20) null check (estado in ('Presente','Ausente','Tarde')),
    foreign key (id_estudiante) references Estudiante(id_estudiante),
    foreign key (id_asignatura) references Asignatura(id_asignatura)
);

-- Tabla de Solicitudes
create table Solicitud (
    id_solicitud int primary key identity(1,1),
    id_estudiante int not null,
    id_asignatura int not null,
    tipo varchar(50) not null check (tipo in ('Revision Nota','Revision Asistencia')),
    descripcion text,
    estado varchar(20) not null default 'Pendiente' check (estado in ('Pendiente','Aprobada','Rechazada')),
    fecha datetime not null default getdate(),
    foreign key (id_estudiante) references Estudiante(id_estudiante),
    foreign key (id_asignatura) references Asignatura(id_asignatura)
);

create table Estudiante_Asignatura (
    id_estudiante int not null,
    id_asignatura int not null,
    primary key (id_estudiante, id_asignatura),
    foreign key (id_estudiante) references Estudiante(id_estudiante),
    foreign key (id_asignatura) references Asignatura(id_asignatura)
);


select * from Usuario

select * from Estudiante

select * from Profesor

select * from Calificacion

select * from Asignatura

select * from Solicitud

select * from Asistencia


delete Usuario from Usuario where id_usuario = 5

INSERT INTO Usuario (nombre, correo, contrasena, rol)
VALUES
('Carlos Ramírez', 'carlos.ramirez@correo.com', 'Carlos123*', 'estudiante'),
('Laura Torres', 'laura.torres@correo.com', 'Laura456*', 'profesor');

INSERT INTO Usuario (nombre, correo, contrasena, rol)
VALUES ('Admin1', 'admin@correo.com', '1234', 'administrador');

insert into estudiante (id_usuario, semestre)
values (1, 3);
insert into profesor (id_usuario, especialidad)
values (2, 'Ingeniería de Sistemas');


insert into asignatura (nombre, creditos, id_profesor)
values ('Matemáticas', 3, 1);

insert into asignatura (nombre, creditos, id_profesor)
values ('Programación', 4, 1);

insert into asignatura (nombre, creditos, id_profesor)
values ('Bases de Datos', 3, 1);

insert into asignatura (nombre, creditos, id_profesor)
values ('POO', 4, 1);


insert into calificacion (id_estudiante, id_asignatura, nota)
values (1, 1, 4.5);

insert into calificacion (id_estudiante, id_asignatura, nota)
values (1, 2, 4.0);

insert into calificacion (id_estudiante, id_asignatura, nota)
values (1, 3, 3.8);

insert into calificacion (id_estudiante, id_asignatura, nota)
values (1, 4, 4.7);


insert into Estudiante_Asignatura (id_estudiante, id_asignatura)
values (1, 5), (1, 6);


select e.id_estudiante, u.nombre as nombrecompleto
from Estudiante e
inner join Usuario u on e.id_usuario = u.id_usuario
inner join Estudiante_Asignatura ea on e.id_estudiante = ea.id_estudiante
where ea.id_asignatura = @idAsignatura;


select u.nombre as estudiante, a.nombre as asignatura, c.nota
from calificacion c
inner join estudiante e on c.id_estudiante = e.id_estudiante
inner join usuario u on e.id_usuario = u.id_usuario
inner join asignatura a on c.id_asignatura = a.id_asignatura;


select e.id_estudiante, u.nombre as nombrecompleto
from Estudiante e
inner join Usuario u on e.id_usuario = u.id_usuario;
