using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IOrderManager>(provider => 
{
    var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();
    optionsBuilder.UseSqlite("Data Source=TaskDataBase.db");

    var taskContext = new OrderContext(optionsBuilder.Options);
    taskContext.Database.EnsureCreated();

    IOrderRepository taskRepository = new OrderRepository(taskContext);
    IOrderManager taskManager = new OrderManager(taskRepository);

    return taskManager;
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

app.Run();