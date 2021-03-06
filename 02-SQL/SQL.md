	+----+-------------------+
	| tabela_pessoa 	 |
	+----+-------------------+
	| id | nome           	 |
	+----+-------------------+
	|  1 | John Doe      	 |
	|  2 | Jane Doe      	 |
	|  3 | Alice Jones   	 |
	|  4 | Bobby Louis  	 |
	|  5 | Lisa Romero 	 |
	+----+-------------------+
	+----+----------------+-----------------+
	| tabela_evento                        	|
	+----+----------------+-----------------+
	| id | evento         | pessoa_id  	|
	+----+----------------+-----------------+
	|  1 | Evento A       |  2	        |
	|  2 | Evento B       |  3              |
	|  3 | Evento C       |  2              |
	|  4 | Evento D       |  NULL     	|
	+----+----------------+-----------------+

### Criação de Backups antes de manipular o BD
	CREATE DATABASE BACKUP;
	USE BACKUP;
	CREATE TABLE BKP_TABELA_PESSOA(
		IDBKP INT PRIMARY KEY,
		IDPESSOA INT,
		NOME VARCHAR(100),
	);
	
	CREATE TABLE BKP_TABELA_EVENTO(
		IDBKP INT PRIMARY KEY,
		IDEVENTO INT PRIMARY KEY,
	 	EVENTO VARCHAR(30) NOT NULL,
	 	ID_PESSOA INT, 
	 	FOREIGN KEY(ID_PESSOA) REFERENCES BKP_TABELA_PESSOA(IDPESSOA)
	);

### 2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.

	SELECT NOME, EVENTO
	FROM tabela_pessoa, tabela_evento
	WHERE id = pessoa_id;

### 2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
	
	SELECT SOBRENOME
	FROM tabela_pessoa
	WHERE nome LIKE '%Doe%';

### 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
	
	UPDATE tabela_evento 
	SET evento = Evento E
	WHERE id = 5,
	INSERT INTO tabela_evento VALUES (5, 'Evento E', 5);

### 2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'
	
	UPDATE tabela_evento 
	SET evento = 'Evento D', nome = 'Joh Doe', pessoa_id = 1
	WHERE id = 4;

### 2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.

	ALTER TABLE tabela_evento
	DROP nome = 'Evento B', id = 4;

### 2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.
Gerênciamento de tabelas
	
	DELETE FROM tabela_pessoa 
	WHERE tabela_evento 
	pessoa_id = NULL;
		

### 2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
	
	ALTER TABLE tabela_pessoa
	ADD idade INTEGER(3);

### 2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:
* id: int (PK)
* telefone: varchar(200)
* pessoa_id: int(FK)

		CREATE TABLE tabela_telefone(
			id INTEGER PRIMARY KEY,
			telefone VARCHAR(200),
			pessoa_id INT,
			FOREIGN KEY(pessoa_id) REFERENCES tabela_pessoa(id)
		);

### 2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

	ALTER TABLE tabela_telefone
	ADD COLUMN indice VARCHAR(30) UNIQUE;

### 2.10 Crie uma query para remover a 'tabela_telefone'.

	DROP TABLE tabela_telefone;