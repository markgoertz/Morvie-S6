using MediatR;
using Morvie_Review.Application.Interfaces;
using Morvie_Review.Infrastructure.Repositories;
using CommandsMediatR = Morvie_Review.Application.Commands;
using QueriesMediatR = Morvie_Review.Application.Queries;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injections via MediatR:
builder.Services.AddMediatR(new Type[]
{
    typeof(CommandsMediatR.CreateReviewCommand),
    typeof(QueriesMediatR.GetAllReviews.GetAllReviewsQuery),
    typeof(QueriesMediatR.GetReview.GetReviewQuery)
});

// Inject normal dependencies:
builder.Services.AddScoped<ICommandReviewRepository, MockCommandReviewRepository>();
builder.Services.AddScoped<IQueryReviewRepository, MockQueryReviewRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
