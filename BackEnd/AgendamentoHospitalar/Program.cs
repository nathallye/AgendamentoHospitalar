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


builder.Services.AddDbContext<AgendamentoHospitalar.Repository.Context.DatabaseContext>();

builder.Services.AddScoped<AgendamentoHospitalar.Interface.IBeneficiarioRepository, AgendamentoHospitalar.Repository.BeneficiarioRepository>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IHospitalRepository, AgendamentoHospitalar.Repository.HospitalRepository>();

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyRuleCors",
        policy =>
        {
            policy.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod();

        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyRuleCors");

app.UseHttpsRedirection();

app.UseCors("MinhaRegraCors");

app.UseAuthorization();

app.UseCors("RegraCors");

app.MapControllers();

app.Run();

