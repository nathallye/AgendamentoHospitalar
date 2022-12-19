var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AgendamentoHospitalar.Context.DatabaseContext>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IProfissionalRepository, AgendamentoHospitalar.Repository.ProfissionalRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("RegraCors",
    policy =>
    {
        policy.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod();



    });
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("MinhaRegraCors",
        policy =>
        {
            policy.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod();

        });
});

builder.Services.AddDbContext<AgendamentoHospitalar.Repository.Context.DatabaseContext>();

builder.Services.AddScoped<AgendamentoHospitalar.Interface.IBeneficiarioRepository, AgendamentoHospitalar.Repository.BeneficiarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MinhaRegraCors");

app.UseAuthorization();

app.UseCors("RegraCors");

app.MapControllers();

app.Run();

