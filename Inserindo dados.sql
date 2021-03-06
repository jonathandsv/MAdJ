/****** script for selecttopnrows command from ssms  ******/
--select top 1000 [id]
--      ,[nome]
--      ,[letra]
--      ,[status]
--      ,[dletra]
--      ,[dnotas]
--  from [mads].[dbo].[musicas]

use Mads

select * from Musicas


select * from Eventos
insert into Eventos (IDEventoPerfil, Titulo, Descricao, Hora, Data, Local) VALUES (1, 'Missa do Segundo Domingo', 'Responsabilidade da missa do segundo domingo do mês', '16:44:02', '2019-01-04', 'Capela Nossa Senhora Aparecida')


insert into EventoPerfil (IDEventoPerfil, Descricao) values (1, 'Missas')
insert into EventoPerfil (IDEventoPerfil, Descricao) values (2, 'Louvor')


select * from EventoPerfil

insert into Musicas (Nome, Letra, AtivoNaoAtivo, DLetra, DNotas, CVideo) values('Um Minuto para o fim do mundo', 'Me sinto só
Mas quem é que nunca se sentiu assim
Procurando um caminho pra seguir uma direção
Respostas!
Um minuto para o fim do mundo
Toda sua vida em 60 segundos
Uma volta no ponteiro do relógio pra viver

O tempo corre contra mim
Sempre foi assim e sempre vai ser
Vivendo apenas pra vencer a falta que me faz você
De olhos fechados eu tento esconder a dor agora
Por favor entenda eu preciso ir embora porque

Quando estou com você
Sinto meu mundo acabar
Perco o chão sob os meus pés
Me falta o ar pra respirar
E só de pensar em te perder por um segundo
Eu sei que isso é o fim do mundo

Volto o relógio para trás tentando adiar o fim
Tentando esconder o medo de te perder quando me sinto assim
De olhos fechados eu tento enganar meu coração
Fugir pra outro lugar em uma outra direção porque

Quando estou com você
Sinto meu mundo acabar
Perco o chão sob os meus pés
Me falta o ar pra respirar
E só de pensar em te perder por um segundo
Eu sei que isso é o fim do mundo

Quando estou com você
Sinto meu mundo acabar
Perco o chão sob os meus pés
Me falta o ar pra respirar
E só de pensar em te perder por um segundo
Eu sei que isso é o fim do mundo

Eu sei que isso é o fim do mundo

Eu sei que isso é o fim
Eu sei que isso é o fim

Eu sei que isso é o fim do mundo!', 'Ativo', 'https://www.letras.mus.br/cpm-22/127044/', 'https://www.cifraclub.com.br/cpm-22/um-minuto-para-fim-do-mundo/', 'https://www.youtube.com/watch?v=RsEeyZNiwUk')


---Inserindo perfil de usuario e novo usuario

select * from PerfilUsuario

  INSERT INTO PerfilUsuario (IDPerfil, Descricao) values (1, 'Admin')

  Insert into PerfilUsuario(IDPerfil, Descricao) values (2, 'Membro')

  SELECT * FROM Usuarios

insert into Usuarios (Nome, Sobrenome, IDPerfilUsuario, Senha, Email, Sexo, Idade) values ('Jonathan', 'Vieira', 1, '123456', 'jonathanvieira@outlook.com', 'M', 22 )

select * from Usuarios where Nome = 'Jonathan'

update Usuarios set Nome = 'jonathan', Sobrenome = 'vieira' where IDUsuario = 1

---Sempre cadastrar usuarios com letra minuscula 


---Cadastrando Postagem------

use Mads
select * from Postagens

insert into Postagens (IDUsuario, IDEnsaio, Titulo, Descricao, Hora, Data) values (1, 1, 'Evolução do batido', 'Hoje o ensaio foi bem profeitoso para mim, consegui melhorar o batido do cântico de entrada.', '15:04:00', '2019-01-15')

update Postagens set IDEvento = 0 where IDPostagem = 1


---Depois de inserir nova coluna de excluidos na tabela de ensaio 
update Eventos Set Excluido = 0;

  SELECT * FROM Eventos WHERE Excluido = 0