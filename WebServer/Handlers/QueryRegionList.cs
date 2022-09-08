﻿using Weedwacker.Shared.Utils;
using Ceen;
using Weedwacker.WebServer;

namespace Weedwacker.WebServer.Handlers
{
    internal class QueryRegionList : IHttpModule
    {
        public Task<bool> HandleAsync(IHttpContext context)
        {
            //TODO implement event system and add this event

            var rsp = context.Response;
            rsp.WriteAllAsync(RegionManager.RegionListResponse);
            // Log to console.
            Logger.WriteLine(String.Format("[Dispatch] Client {0}s request: query_region_list", context.GetRemoteIP()));
            return Task.FromResult(true);
        }

    }
}