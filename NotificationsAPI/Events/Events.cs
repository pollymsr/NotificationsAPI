using System;

namespace FiapCloudGames.Events;

public record UserCreatedEvent(Guid UserId, string Name, string Email);
public record PaymentProcessedEvent(Guid UserId, Guid GameId, string Status);
