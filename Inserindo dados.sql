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