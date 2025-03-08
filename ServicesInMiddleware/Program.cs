using ServicesInMiddleware.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Transient: ������ ������� ��������� ������ ���, ����� ��������� ��������� ������ �������. 
// �������� ������ ���������� ����� �������� �������� ��� ����������� ��������, ������� �� ������ ������ � ���������.
//builder.Services.AddCounterService();

// Scoped: ��� ������� ������� ��������� ���� ������ �������.
//builder.Services.AddScoped<ICounter, RandomCounter>();
//builder.Services.AddScoped<CounterService>();

// Singleton: ������ ������� ��������� ��� ������ ��������� � ����, 
// ��� ����������� ������� ���������� ���� � ��� �� ����� ��������� ������ �������
builder.Services.AddSingleton<ICounter, RandomCounter>();
builder.Services.AddSingleton<CounterService>();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
