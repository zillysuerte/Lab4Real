using Lab4Real;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

/*EquationSolver solver = new EquationSolver();

app.MapGet("/hasRoots", (HttpContext httpContex, int id) =>
{
    return solver.GetEquationAt(id-1).HasRoots;
})
    .WithName("HasRoots");

app.MapGet("/getEquationAt", (HttpContext httpContex, int id) =>
{
    return solver.GetEquationAt(id-1).toSolutionsData();
})
    .WithName("GetEquationAt");*/

/*app.MapGet("/add", (HttpContext httpContex, EquationsData equationsData) =>
{
    EquationMember cx = new EquationMember(equationsData.C, 0);
    EquationMember bx = new EquationMember(equationsData.B, 1);
    EquationMember ax = new EquationMember(equationsData.A, 2);

    var parts = new EquationMember[] { cx, bx, ax };

    Equation equation = new Equation(parts);
    Solution solution = equation.Result;
    solver.Add(solution);
    return solver;
})
    .WithName("Add");*/


app.MapControllers();

app.Run();
