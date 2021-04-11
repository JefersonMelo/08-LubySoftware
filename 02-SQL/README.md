# Luby Software

## Tabelas Para Consulta
	
	+- - - - +- - - - - - - - - - - - - - - - - - - +
	| tabela_pessoa 	 |
	+- - - - +- - - - - - - - - - - - - - - - - - - +
	| id | nome           	 |
	+- - - - +- - - - - - - - - - - - - - - - - - - +
	|  1 | John Doe      	 |
	|  2 | Jane Doe      	 |
	|  3 | Alice Jones   	 |
	|  4 | Bobby Louis  	 |
	|  5 | Lisa Romero 	 |
	+- - - - +- - - - - - - - - - - - - - - - - - - +
	+- - - - +- - - - - - - - - - - - - - - - +- - - - - - - - - - - - - - - - - +
	| tabela_evento                        	|
	+- - - - +- - - - - - - - - - - - - - - - +- - - - - - - - - - - - - - - - - +
	| id | evento         | pessoa_id  	|
	+- - - - +- - - - - - - - - - - - - - - - +- - - - - - - - - - - - - - - - - +
	|  1 | Evento A       |  2	        |
	|  2 | Evento B       |  3              |
	|  3 | Evento C       |  2              |
	|  4 | Evento D       |  NULL     	|
	+- - - - +- - - - - - - - - - - - - - - - +- - - - - - - - - - - - - - - - - +

### Criação de Backups antes de manipular o BD

<!-- 
Para criar tabelas backup tem um comando que ele cria a copia da tabela, inclusive
em dados, é um comando 'SELECT INTO' com 'FROM' 
Ex: 
Select*INTO BKP_TABELA_PESSOA (não precisa pré criar a tabela)
FROM TABELA_PESSOA

Select*INTO BKP_TABELA_EVENTO
	FROM TABELA_EVENTO
-->

```"
SELECT * INTO BKP_TABELA_PESSOA
FROM TABELA_PESSOA
GO

SELECT * INTO BKP_TABELA_EVENTO
FROM TABELA_EVENTO
GO
```

### 2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam

```"
SELECT NOME, ISNULL(EVENTO, 'Sem Eventos') AS 'Eventos'
FROM tabela_pessoa a
LEFT JOIN tabela_evento b
ON a.id = b.pessoa_id
GO
```

### 2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.  

<!--
 A query, tá quase rsrsr...a coluna SobreNome não existe, eu faria assim
-->

```"
SELECT *
FROM tabela_pessoa
WHERE nome LIKE '%Doe'
GO
```

### 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'

<!--
Nesse caso seria necessário apenas o Insert
-->

```"
INSERT tabela_evento VALUES ('Evento E', 5)
GO
```

### 2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'

<!--
Não precisa atualizar todos os campos, se não fosse o campo 'nome' que não
existe nessa tabela, estaria correto
-->

```"
UPDATE tabela_evento  
SET PESSOA_ID = 1 WHERE = 4
GO
```

### 2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'

<!--
Esse era pra fazer um Delete, Alter Table mexe em estrutura da tabela
-->

```"
DELETE tabela_evento
WHERE id = 2
GO
```

### 2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados

<!--
A lógica eu entendi, pensou certinho, mas a sintaxe seria essa
-->

- Gerênciamento de tabelas

```"
DELETE tabela_pessoa 
WHERE tabela_evento 
ID NOT IN (SELECT PESSOA_ID FROM TABELA_EVENTO)
GO
```

### 2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)

<!--
Tá correto, só retirar o (3) porque inteiro tem delimitação fixa já
-->

```"
ALTER TABLE tabela_pessoa
ADD idade INT
GO
```

### 2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa 

<!--
á certinho, coloar o IDENTITY no Id, e tratar os que podem ou não receber nulo,
mas é só um toque, porque tá correto
-->

- Com seguintes campos:
  - id: int (PK)
  - telefone: varchar(200)
  - pessoa_id: int(FK)

```"
CREATE TABLE tabela_telefone(
	id INTEGER PRIMARY KEY IDENTITY,
	telefone VARCHAR(200),
	pessoa_id INT,
	FOREIGN KEY(pessoa_id) REFERENCES tabela_pessoa(id)
)
GO
```

### 2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

<!--
Index é como se fosse uma "constraint" que você utiliza para otimizar a tabela,
para a busca ficar mais rápida 
-->

```"
CREATE UNIQUE INDEX index_Telefone
ON TABLELA_TELEFONE(Telefone)
GO
```

### 2.10 Crie uma query para remover a 'tabela_telefone'.

```"
DROP TABLE tabela_telefone
GO
```
