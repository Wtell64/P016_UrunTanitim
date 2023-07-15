var builder = WebApplication.CreateBuilder(args); //Yapabiliceklerimizi define ediyorum
//Bir pojenin hangi katmanlar olmasi gerektigini. Tasiyici olur.
// Add services to the container.
builder.Services.AddControllersWithViews(); //Bu projenin bir mvc oldugunu soyluyor

var app = builder.Build(); //proje nin geneli mutahiti. Kullanilicak herseye karar veren appdir. Bu projede nail ayaga kaldirilicagi hangi birimlerden olusturnu.
//Hangi katmanlardan ollustunugnu soyluyor.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); //bu projede statis dosyalar olucak wwwroot

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
