using Microsoft.Owin;
using System;

namespace OWIN.demo.Middleware
{
    public class DebugMiddlewareOptions
    {
        public Action<OwinContext> OnIncomingRequest { get; set; }
        public Action<OwinContext> OnOutgoingRequest { get; set; }

    }
}