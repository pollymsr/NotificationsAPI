# 📧 NotificationsAPI

O **NotificationsAPI** atua como o sistema nervoso de comunicação do ecossistema Fiap Cloud Games. Ele é um *worker isolado* especializado apenas em escutar eventos importantes e **notificar os usuários**.

## Funcionalidades
- **Boas Vindas:** Escuta o evento `UserCreatedEvent`. Assim que um usuário se cadastra no `UsersAPI`, este worker intercepta o evento e emite (simula no console) o envio de um e-mail de boas-vindas.
- **Recibos de Compras:** Escuta o evento `PaymentProcessedEvent`. Caso o pagamento de um jogo retorne como Aprovado ou Recusado do `PaymentsAPI`, este serviço avisa o usuário do resultado via e-mail (simulação via console log).

## Como funciona
Este serviço **não tem endpoints REST**. Ele apenas consome mensagens do RabbitMQ via MassTransit, tornando a arquitetura leve e altamente escalável.

## Tecnologias Utilizadas
- C# .NET 8 Worker Service
- MassTransit + RabbitMQ
- Docker (Multi-stage build)
