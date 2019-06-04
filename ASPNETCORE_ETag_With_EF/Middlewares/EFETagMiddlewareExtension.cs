using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Middlewares {
    public static class EFETagMiddlewareExtension {
        public static IApplicationBuilder UseEFETag<TContext>(this IApplicationBuilder app)
            where TContext : DbContext {
            return app.UseResponseBuffering() // 必須要使用Buffering，如此才能在寫入Body後還可以修改狀態碼
                .UseMiddleware<EFETagMiddleware<TContext>>(); // 使用前面建立的Middleware
        }
    }
}
