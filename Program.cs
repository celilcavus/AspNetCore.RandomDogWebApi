var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddMvc(x=>{
    x.EnableEndpointRouting = false;
});

var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.UseMvc(x=>{
    x.MapRoute(
        name:"default",
        template:"{controller=Home}/{action=Index}"
    );
});
app.Run();
