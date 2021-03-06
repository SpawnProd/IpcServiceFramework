﻿using JKang.IpcServiceFramework.NamedPipe;

namespace JKang.IpcServiceFramework
{
    public static class NamedPipeIpcServiceHostBuilderExtensions
    {
        public static IpcServiceHostBuilder AddNamedPipeEndpoint<TContract>(this IpcServiceHostBuilder builder,
            string name, string pipeName, bool includeFailureDetailsInResponse = false)
            where TContract: class
        {
            return builder.AddEndpoint(new NamedPipeIpcServiceEndpoint<TContract>(name, builder.ServiceProvider, pipeName,
                includeFailureDetailsInResponse: includeFailureDetailsInResponse));
        }
    }
}
