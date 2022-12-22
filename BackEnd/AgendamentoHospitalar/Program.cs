
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AgendamentoHospitalar.Repository.Context.DatabaseContext>();

builder.Services.AddScoped<AgendamentoHospitalar.Interface.IProfissionalRepository, AgendamentoHospitalar.Repository.ProfissionalRepository>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IBeneficiarioRepository, AgendamentoHospitalar.Repository.BeneficiarioRepository>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IHospitalRepository, AgendamentoHospitalar.Repository.HospitalRepository>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IAgendamentoRepository, AgendamentoHospitalar.Repository.AgendamentoRepository>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IAgendamentoConfiguracaoRepositorio, AgendamentoHospitalar.Repository.AgendamentoConfiguracaoRepositorio>();
builder.Services.AddScoped<AgendamentoHospitalar.Interface.IEspecialidadeRepositorio, AgendamentoHospitalar.Repository.EspecialidadeRepositorio>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();

