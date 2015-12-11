﻿namespace NServiceBus
{
    using NServiceBus.Pipeline;
    using NServiceBus.Pipeline.Contexts;
    using NServiceBus.Transports;

    /// <summary>
    /// A context of behavior execution in physical message processing stage.
    /// </summary>
    class IncomingPhysicalMessageContextImpl : IncomingContextImpl, IncomingPhysicalMessageContext
    {
        public IncomingPhysicalMessageContextImpl(IncomingMessage message, BehaviorContext parentContext)
            : base(message.MessageId, message.GetReplyToAddress(), message.Headers, parentContext)
        {
            Message = message;
        }

        public IncomingMessage Message { get; }
    }
}