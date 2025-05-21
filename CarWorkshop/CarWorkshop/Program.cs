// ---
// 1. Registration of the dependencies of our app.
// ---

using CarWorkshop.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register our database context.
builder.Services.AddDbContext<DatabaseContext>();

// ---
// 2. Configure.
// ---

var app = builder.Build();


{ // Configure the HTTP request pipeline.

    // Debug Build
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production
        //  scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection(); // no-https -> redirect to https.
    app.UseRouting();
    app.UseAuthorization();
    app.MapStaticAssets();

    // A way of behaving.
    //  controller
    //  action
    //  (optional) ip
    // If we stary our application without any additional path -> this will
    //  make the default controller home with action of redirect to index.
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}" 
        ).WithStaticAssets();

    app.Run();
}
