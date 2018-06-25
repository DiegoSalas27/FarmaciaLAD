
use FarmaciaDB
-- Llenar tabla Laboratorios

insert into Laboratorio values (4415621,'Lab. Los pinos','Av. Arequipa 430','LosPinos@gmail.com',1, 123456789, 'Los pinos sac', 'Lima', 'Peru');

insert into Laboratorio values (3489126,'Lab. La Buena Salud','Av Javier Prado Oeste 844','diegosalas27@hotmail.com',1, 112356789, 'La buena salud SA', 'Chimbote', 'Peru');

insert into Laboratorio values (5490761,'Lab. MedicSA','Av. Guardia Civil 711','correo2@gmail.com',1, 5443216789, 'Medic SA', 'Huanuco', 'Peru');

insert into Laboratorio values (3276189,'Lab. Oncorp','Av Dionisio Derteano 144','correo3@gmail.com',1, 432156789, 'OnCorp LSA', 'Trujillo', 'Peru');


-- Llenar tabla Categorias

insert into Categoria values ('Perfumes y Lociones');
insert into Categoria values ('Colonias para Hombres');
insert into Categoria values ('Perfumes para Damas');
insert into Categoria values ('Colonias para Niños');
insert into Categoria values ('Productos Farmaceuticos');
insert into Categoria values ('Jarabes');
insert into Categoria values('Tabletas');
insert into Categoria values ('Pildoras');
insert into Categoria values ('Ungüentos');
insert into Categoria values ('Antisépticos');
insert into Categoria values('Medicamentos');
insert into Categoria values('Antibióticos');
insert into Categoria values ('Desodorantes')
insert into Categoria values ('Gel para Cabello')
insert into Categoria values ('Bloqueadores Solares')
insert into Categoria values('Bebes')

delete from Categoria

-- Llenar marcas

INSERT INTO Marca
VALUES('DIACETAZ');
INSERT INTO Marca
VALUES('ISAVIR');
INSERT INTO Marca
VALUES('ZOVIRAX');
INSERT INTO Marca
VALUES('ZOYLEX');
INSERT INTO Marca
VALUES('CESUMAR');
INSERT INTO Marca
VALUES('CICLOVIRAL');
INSERT INTO Marca
VALUES('CLOVIRAX');
INSERT INTO Marca
VALUES('VIRUNEF');
INSERT INTO Marca
VALUES('URBASON');
INSERT INTO Marca
VALUES('ACEVIR');
INSERT INTO Marca
VALUES('ACICLOSAN');
INSERT INTO Marca
VALUES('CLOVIRAX-400');
INSERT INTO Marca
VALUES('HERPERAX');
INSERT INTO Marca
VALUES('VIRONIDA');
INSERT INTO Marca
VALUES('ASPIRINA');
INSERT INTO Marca
VALUES('ASPISAN');
INSERT INTO Marca
VALUES('CARDIO ALIV');
INSERT INTO Marca
VALUES('CARDIOASPIRINA');
INSERT INTO Marca
VALUES('COR-ASA');
INSERT INTO Marca
VALUES('COR-ASPI');
INSERT INTO Marca
VALUES('ECOTRIN');
INSERT INTO Marca
VALUES('PUROL');
INSERT INTO Marca
VALUES('SANOGAL');
INSERT INTO Marca
VALUES('FOLISAN');
INSERT INTO Marca
VALUES('MEJORAL DESCAF');
INSERT INTO Marca
VALUES('LAGRIMAS ARTIFICIALS');
INSERT INTO Marca
VALUES('LAGRIMAS ISOTONICAS');
INSERT INTO Marca
VALUES('ALOXIN');
INSERT INTO Marca
VALUES('TRANQUINAL');
INSERT INTO Marca
VALUES('ANSIOLIN');
INSERT INTO Marca
VALUES('TRYPTANOL');
INSERT INTO Marca
VALUES('BUSCAPINA');
INSERT INTO Marca
VALUES('COLGATE');
INSERT INTO Marca
VALUES('KOLYNOS');
INSERT INTO Marca
VALUES('REXONA');
INSERT INTO Marca
VALUES('OLD SPICE');
INSERT INTO Marca
VALUES('ORAL B');
INSERT INTO Marca
VALUES('ENFAGROW');
INSERT INTO Marca
VALUES('PANADOL');
insert into Marca values('QUILAB')
insert into Marca values('QUANOX')
insert into Marca values('DESTOLIT')
insert into Marca values('EGO')
insert into Marca values('BAHIA')
insert into Marca values('Pampers')

-- Llenar tabla Presentacion

INSERT INTO Presentacion VALUES('Desodorante')
INSERT INTO Presentacion VALUES('Masticable')
INSERT INTO Presentacion VALUES('Jabon')
INSERT INTO Presentacion VALUES('Pañal')
INSERT INTO Presentacion VALUES('Polvo Encapsulado')
INSERT INTO Presentacion VALUES('Oleosacaruro')
INSERT INTO Presentacion VALUES('Comprimido')
INSERT INTO Presentacion VALUES('Píldora')
INSERT INTO Presentacion VALUES('Extracto')
INSERT INTO Presentacion VALUES('Supositorio')
INSERT INTO Presentacion VALUES('Pomada')
INSERT INTO Presentacion VALUES('Pasta')
INSERT INTO Presentacion VALUES('Emplasto')
INSERT INTO Presentacion VALUES('Crema')
INSERT INTO Presentacion VALUES('Agua aromática')
INSERT INTO Presentacion VALUES('Inyección')
INSERT INTO Presentacion VALUES('Jarabe')
INSERT INTO Presentacion VALUES('Poción')
INSERT INTO Presentacion VALUES('Mucílago')
INSERT INTO Presentacion VALUES('Emulsión')
INSERT INTO Presentacion VALUES('Loción')
INSERT INTO Presentacion VALUES('Suspensión')
INSERT INTO Presentacion VALUES('Colirios')
INSERT INTO Presentacion VALUES('Tinturas')
INSERT INTO Presentacion VALUES('Vino Medicinal')
INSERT INTO Presentacion VALUES('Colodión')
INSERT INTO Presentacion VALUES('Linimentos')
INSERT INTO Presentacion VALUES('Óxido Nitroso')
INSERT INTO Presentacion VALUES('Aerosol')
INSERT INTO Presentacion VALUES('Dispersión líquida')
INSERT INTO Presentacion VALUES('Elixir')
INSERT INTO Presentacion VALUES('Cápsula')
INSERT INTO Presentacion VALUES('Granulado')
INSERT INTO Presentacion VALUES('Sello')
INSERT INTO Presentacion VALUES('Tableta')
INSERT INTO Presentacion VALUES('Barra')

insert into usuario values('Andrés', 'daztery@gmail.com', 123456789, 'almacenero')
insert into usuario values('Manuel', 'alvaradomanuel2013@gmail.com', 12345678, 'almacenero')
insert into usuario values('Miguel', 'miguel.9dc@gmail.com', 1234567, 'almacenero')
insert into usuario values('Diego', 'dominicsc2hs@gmail.com', 123456, 'administrador')

insert into Producto values('Old Spice WolfThorn', NULL, 7.00, 0, 50.00, 'gr', 18-06-12, 17, 13, 1, 1)
insert into Producto values('Old Spice NightThrorn', NULL, 8.00, 0, 50.00, 'gr', 18-06-12,18, 13, 1, 1)
insert into Producto values('Old Spice Bambú', NULL, 9.00, 0, 50.00, 'gr', 18-06-12, 19, 13, 4, 1)
insert into Producto values('Ivermectina', '6 mg', 30.00, 0, 5.00, 'ml', 18-06-12, 20, 11, 2, 2)
insert into Producto values('Permetrina', '5%', 40.00, 0, 30.00, 'gr', 18-06-12, 21, 9, 1, 3)
insert into Producto values('Dextometorfano', '15mg', 8.00, 0, 5.00, 'ml', 18-06-12, 22, 11, 4, 3)
insert into Producto values('Ego', NULL, 4.00, 0, 100.00, 'gr', 18-06-12, 23, 13, 2, 3)
insert into Producto values('Faces', '90 SPF', 60.00, 0, 0.06, 'gr', 18-06-12, 24, 15, 1, 4)
insert into Producto values('Pañales Babysec', null, 38.90, 0, 200, 'unidades', 18-06-12,  25, 20, 4, 1)

select * from Producto
select * from Marca