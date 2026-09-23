Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.EntityFrameworkCore

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        builder.Services.AddControllers()

        builder.Services.AddDbContext(Of AppDbContext)(
        Sub(options)
            options.UseSqlServer(
            builder.Configuration("ConnectionStrings:ConexionBD")
            )
        End Sub
        )

        builder.Services.AddScoped(Of ClienteRepository)
        builder.Services.AddScoped(Of ClienteService)

        Dim app = builder.Build()
        app.MapControllers()
        app.Run()
    End Sub
End Module
