# BikesStore
1. use command below to gen BikesStoreDbContext
dotnet ef dbcontext scaffold "Server=localhost\VietTQ22;Database=BikesStore;User Id=sa;Password=123456Viet;MultipleActiveResultSets=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Data/Entities -f

2. Register BikesStoreDbContext to DI container ( in Program.cs
builder.Services.AddDbContext<BikesStoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BikesStoreConnString")));)

3. Generate scafolding