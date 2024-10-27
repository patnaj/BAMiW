using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using LAB1.Data;
using LAB1.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LAB1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<UserModel>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddRoles<RoleModel>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // zmiana ciastko widoczne w skrypcie
            services.ConfigureApplicationCookie(options=>{
                options.Cookie.HttpOnly = false;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();

            UserSeed(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // header
            app.Use(async (context, next) =>{
                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                await next();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            

        }

        async void UserSeed(IServiceCollection services, bool restoreUsers = true)
        {
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<UserModel>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<RoleModel>>();

            if (!await roleManager.RoleExistsAsync("User"))
                await roleManager.CreateAsync(new RoleModel() { Id = 1, Name = "User" });
            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new RoleModel() { Id = 2, Name = "Admin" });

            if (dbContext.Users.FirstOrDefault(i => i.Id == 1) == null)
            {
                var user = new UserModel() { Id = 1, UserName = "adam@example.com", NormalizedUserName = "adam@example.com", Email = "adam@example.com", NormalizedEmail = "adam@example.com", EmailConfirmed = true, SecurityStamp = string.Empty };
                var res = await userManager.CreateAsync(user, "testtest@1");
                await userManager.AddToRoleAsync(user, "User");
                await userManager.AddToRoleAsync(user, "Admin");
            }
            if (dbContext.Users.FirstOrDefault(i => i.Id == 2) == null)
            {
                var user = new UserModel() { Id = 2, UserName = "jan@example.com", NormalizedUserName = "jan@example.com", Email = "jan@example.com", NormalizedEmail = "jan@example.com", EmailConfirmed = true, SecurityStamp = string.Empty };
                await userManager.CreateAsync(user, "testtest@1");
                await userManager.AddToRoleAsync(user, "User");
            }

            if (dbContext.Messages.FirstOrDefault(i => i.Id == 2) == null)
                dbContext.Messages.AddRange(
                    new Message() { Id = 1, Date = DateTime.Now.AddDays(-2), UserId = 2, Text = "<b>Lorem Ipsum</b> is simply dummy text of the printing and typesetting industry.<br> Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," },
                    new Message() { Id = 2, Date = DateTime.Now.AddDays(-1), UserId = 1, Text = "<b>Lorem Ipsum</b> is <u>simply dummy text of the printing</u> and typesetting industry.<br> Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," }
                );

            if (dbContext.Invoices.FirstOrDefault(i => i.ID == 1) == null)
                dbContext.Invoices.AddRange(
                    new InvoiceModel() { ID = 1, Address = "Fairview 5451, New Orleans - 6420, The Bahamas", Date = DateTime.Now, UserID = 1 },
                    new InvoiceModel() { ID = 2, Address = "Garland - 2327, Dominican Republic", Date = DateTime.Now, UserID = 1 },
                    new InvoiceModel() { ID = 3, Address = "To nie moje, Ellerslie 5206, Wien - 7026, Morocco", Date = DateTime.Now, UserID = 2 },
                    new InvoiceModel() { ID = 4, Address = "Garfield 8152, Cincinnati - 6755, Djibouti", Date = DateTime.Now, UserID = 1 },
                    new InvoiceModel() { ID = 5, Address = "Chesterfield  3014, Columbus - 2530, Grenada", Date = DateTime.Now, UserID = 1 }
                );

            if (dbContext.InvoiceItems.FirstOrDefault(i => i.ID == 1) == null)
                dbContext.InvoiceItems.AddRange(
                    new InvoiceItemModel() { ID = 1, IvoiceID = 3, Amount = 17, Price = 87.83f, ProductName = "	Crackers - Water	" },
                    new InvoiceItemModel() { ID = 2, IvoiceID = 4, Amount = 14, Price = 79.02f, ProductName = "	Steam Pan - Half Size Deep	" },
                    new InvoiceItemModel() { ID = 3, IvoiceID = 1, Amount = 1, Price = 92.17f, ProductName = "	Sprouts - Pea	" },
                    new InvoiceItemModel() { ID = 4, IvoiceID = 1, Amount = 77, Price = 92.06f, ProductName = "	Apple - Custard	" },
                    new InvoiceItemModel() { ID = 5, IvoiceID = 1, Amount = 93, Price = 8.05f, ProductName = "	Tamarind Paste	" },
                    new InvoiceItemModel() { ID = 6, IvoiceID = 5, Amount = 90, Price = 90.38f, ProductName = "	Parsley Italian - Fresh	" },
                    new InvoiceItemModel() { ID = 7, IvoiceID = 3, Amount = 71, Price = 3.24f, ProductName = "	Steam Pan - Half Size Deep	" },
                    new InvoiceItemModel() { ID = 8, IvoiceID = 5, Amount = 33, Price = 43.51f, ProductName = "	Mushroom - Crimini	" },
                    new InvoiceItemModel() { ID = 9, IvoiceID = 5, Amount = 1, Price = 51.88f, ProductName = "	Scallops 60/80 Iqf	" },
                    new InvoiceItemModel() { ID = 10, IvoiceID = 3, Amount = 50, Price = 32.92f, ProductName = "	Glass Clear 8 Oz	" },
                    new InvoiceItemModel() { ID = 11, IvoiceID = 5, Amount = 71, Price = 33.12f, ProductName = "	Bagel - Sesame Seed Presliced	" },
                    new InvoiceItemModel() { ID = 12, IvoiceID = 3, Amount = 77, Price = 24.05f, ProductName = "	Mushroom - Enoki, Dry	" },
                    new InvoiceItemModel() { ID = 13, IvoiceID = 5, Amount = 34, Price = 80.34f, ProductName = "	Marjoram - Fresh	" },
                    new InvoiceItemModel() { ID = 14, IvoiceID = 1, Amount = 4, Price = 93.08f, ProductName = "	Veal - Kidney	" },
                    new InvoiceItemModel() { ID = 15, IvoiceID = 2, Amount = 95, Price = 46.69f, ProductName = "	Tortillas - Flour, 12	" },
                    new InvoiceItemModel() { ID = 16, IvoiceID = 1, Amount = 77, Price = 62.66f, ProductName = "	Ecolab - Solid Fusion	" },
                    new InvoiceItemModel() { ID = 17, IvoiceID = 4, Amount = 99, Price = 56.06f, ProductName = "	Marjoram - Fresh	" },
                    new InvoiceItemModel() { ID = 18, IvoiceID = 4, Amount = 10, Price = 38.53f, ProductName = "	Tea - Herbal I Love Lemon	" },
                    new InvoiceItemModel() { ID = 19, IvoiceID = 1, Amount = 66, Price = 53.64f, ProductName = "	Cut Wakame - Hanawakaba	" },
                    new InvoiceItemModel() { ID = 20, IvoiceID = 5, Amount = 19, Price = 78.31f, ProductName = "	Lamb - Shoulder, Boneless	" },
                    new InvoiceItemModel() { ID = 21, IvoiceID = 3, Amount = 66, Price = 85.09f, ProductName = "	Wine - Ej Gallo Sierra Valley	" },
                    new InvoiceItemModel() { ID = 22, IvoiceID = 5, Amount = 54, Price = 98.37f, ProductName = "	Crab - Meat Combo	" },
                    new InvoiceItemModel() { ID = 23, IvoiceID = 4, Amount = 69, Price = 83.26f, ProductName = "	Cheese - Brie,danish	" },
                    new InvoiceItemModel() { ID = 24, IvoiceID = 4, Amount = 84, Price = 77.14f, ProductName = "	Squash - Guords	" },
                    new InvoiceItemModel() { ID = 25, IvoiceID = 5, Amount = 22, Price = 40.23f, ProductName = "	Bag - Bread, White, Plain	" },
                    new InvoiceItemModel() { ID = 26, IvoiceID = 1, Amount = 21, Price = 4.5f, ProductName = "	Cookie Dough - Double	" },
                    new InvoiceItemModel() { ID = 27, IvoiceID = 5, Amount = 61, Price = 72.58f, ProductName = "	Beans - Fava Fresh	" },
                    new InvoiceItemModel() { ID = 28, IvoiceID = 5, Amount = 26, Price = 21.42f, ProductName = "	Broom And Brush Rack Black	" },
                    new InvoiceItemModel() { ID = 29, IvoiceID = 4, Amount = 45, Price = 52.49f, ProductName = "	Chivas Regal - 12 Year Old	" },
                    new InvoiceItemModel() { ID = 30, IvoiceID = 3, Amount = 93, Price = 38.57f, ProductName = "	Crackers - Water	" },
                    new InvoiceItemModel() { ID = 31, IvoiceID = 4, Amount = 99, Price = 97.28f, ProductName = "	Red Cod Fillets - 225g	" },
                    new InvoiceItemModel() { ID = 32, IvoiceID = 1, Amount = 18, Price = 36.43f, ProductName = "	Beans - Fine	" },
                    new InvoiceItemModel() { ID = 33, IvoiceID = 1, Amount = 7, Price = 79.69f, ProductName = "	Mix - Cocktail Ice Cream	" },
                    new InvoiceItemModel() { ID = 34, IvoiceID = 3, Amount = 18, Price = 19.34f, ProductName = "	Pasta - Rotini, Dry	" },
                    new InvoiceItemModel() { ID = 35, IvoiceID = 4, Amount = 94, Price = 52.73f, ProductName = "	Vinegar - White	" },
                    new InvoiceItemModel() { ID = 36, IvoiceID = 4, Amount = 82, Price = 26.06f, ProductName = "	Temperature Recording Station	" },
                    new InvoiceItemModel() { ID = 37, IvoiceID = 5, Amount = 72, Price = 61.11f, ProductName = "	Berry Brulee	" },
                    new InvoiceItemModel() { ID = 38, IvoiceID = 1, Amount = 69, Price = 83.18f, ProductName = "	Pesto - Primerba, Paste	" },
                    new InvoiceItemModel() { ID = 39, IvoiceID = 4, Amount = 98, Price = 81.54f, ProductName = "	Asparagus - White, Fresh	" },
                    new InvoiceItemModel() { ID = 40, IvoiceID = 1, Amount = 60, Price = 57.39f, ProductName = "	Soup - Campbells, Chix Gumbo	" },
                    new InvoiceItemModel() { ID = 41, IvoiceID = 1, Amount = 78, Price = 69.58f, ProductName = "	Oranges - Navel, 72	" },
                    new InvoiceItemModel() { ID = 42, IvoiceID = 2, Amount = 86, Price = 58.0f, ProductName = "	Chocolate - Pistoles, Lactee, Milk	" },
                    new InvoiceItemModel() { ID = 43, IvoiceID = 4, Amount = 24, Price = 81.02f, ProductName = "	Wine - Alsace Gewurztraminer	" },
                    new InvoiceItemModel() { ID = 44, IvoiceID = 3, Amount = 52, Price = 38.11f, ProductName = "	Nantucket - Pomegranate Pear	" },
                    new InvoiceItemModel() { ID = 45, IvoiceID = 3, Amount = 22, Price = 73.08f, ProductName = "	Spice - Peppercorn Melange	" },
                    new InvoiceItemModel() { ID = 46, IvoiceID = 2, Amount = 41, Price = 49.56f, ProductName = "	Sobe - Lizard Fuel	" },
                    new InvoiceItemModel() { ID = 47, IvoiceID = 3, Amount = 73, Price = 87.54f, ProductName = "	Container - Foam Dixie 12 Oz	" },
                    new InvoiceItemModel() { ID = 48, IvoiceID = 3, Amount = 3, Price = 50.02f, ProductName = "	Wine - Red, Colio Cabernet	" },
                    new InvoiceItemModel() { ID = 49, IvoiceID = 2, Amount = 43, Price = 80.98f, ProductName = "	Cheese - Le Cheve Noir	" },
                    new InvoiceItemModel() { ID = 50, IvoiceID = 2, Amount = 25, Price = 71.98f, ProductName = "	Fish - Atlantic Salmon, Cold	" },
                    new InvoiceItemModel() { ID = 51, IvoiceID = 2, Amount = 20, Price = 47.54f, ProductName = "	Bagelers - Cinn / Brown Sugar	" },
                    new InvoiceItemModel() { ID = 52, IvoiceID = 2, Amount = 42, Price = 48.76f, ProductName = "	Chicken - Thigh, Bone In	" },
                    new InvoiceItemModel() { ID = 53, IvoiceID = 4, Amount = 14, Price = 63.23f, ProductName = "	Napkin - Cocktail,beige 2 - Ply	" },
                    new InvoiceItemModel() { ID = 54, IvoiceID = 2, Amount = 73, Price = 72.63f, ProductName = "	Phyllo Dough	" },
                    new InvoiceItemModel() { ID = 55, IvoiceID = 3, Amount = 35, Price = 21.54f, ProductName = "	Soup - Campbells - Tomato	" },
                    new InvoiceItemModel() { ID = 56, IvoiceID = 4, Amount = 98, Price = 91.53f, ProductName = "	V8 Pet	" },
                    new InvoiceItemModel() { ID = 57, IvoiceID = 3, Amount = 58, Price = 59.88f, ProductName = "	Stock - Chicken, White	" },
                    new InvoiceItemModel() { ID = 58, IvoiceID = 1, Amount = 44, Price = 37.51f, ProductName = "	Wine - Port Late Bottled Vintage	" },
                    new InvoiceItemModel() { ID = 59, IvoiceID = 5, Amount = 96, Price = 17.84f, ProductName = "	Beer - Sleemans Honey Brown	" },
                    new InvoiceItemModel() { ID = 60, IvoiceID = 4, Amount = 94, Price = 42.47f, ProductName = "	Wasabi Paste	" },
                    new InvoiceItemModel() { ID = 61, IvoiceID = 4, Amount = 100, Price = 77.25f, ProductName = "	Juice - Orangina	" },
                    new InvoiceItemModel() { ID = 62, IvoiceID = 5, Amount = 56, Price = 19.46f, ProductName = "	Wine - White, Antinore Orvieto	" },
                    new InvoiceItemModel() { ID = 63, IvoiceID = 3, Amount = 75, Price = 36.87f, ProductName = "	Lychee	" },
                    new InvoiceItemModel() { ID = 64, IvoiceID = 2, Amount = 11, Price = 5.48f, ProductName = "	Juice - Lemon	" },
                    new InvoiceItemModel() { ID = 65, IvoiceID = 1, Amount = 8, Price = 77.66f, ProductName = "	Cup - 8oz Coffee Perforated	" },
                    new InvoiceItemModel() { ID = 66, IvoiceID = 3, Amount = 63, Price = 42.36f, ProductName = "	Seaweed Green Sheets	" },
                    new InvoiceItemModel() { ID = 67, IvoiceID = 5, Amount = 58, Price = 95.07f, ProductName = "	Syrup - Pancake	" },
                    new InvoiceItemModel() { ID = 68, IvoiceID = 5, Amount = 10, Price = 28.9f, ProductName = "	Veal - Bones	" },
                    new InvoiceItemModel() { ID = 69, IvoiceID = 5, Amount = 26, Price = 18.31f, ProductName = "	Nut - Pumpkin Seeds	" },
                    new InvoiceItemModel() { ID = 70, IvoiceID = 5, Amount = 21, Price = 89.4f, ProductName = "	Napkin White - Starched	" },
                    new InvoiceItemModel() { ID = 71, IvoiceID = 5, Amount = 72, Price = 14.04f, ProductName = "	Wine - George Duboeuf Rose	" },
                    new InvoiceItemModel() { ID = 72, IvoiceID = 4, Amount = 36, Price = 99.16f, ProductName = "	Onion - Dried	" },
                    new InvoiceItemModel() { ID = 73, IvoiceID = 5, Amount = 72, Price = 23.76f, ProductName = "	Sprouts Dikon	" },
                    new InvoiceItemModel() { ID = 74, IvoiceID = 5, Amount = 7, Price = 28.48f, ProductName = "	Melon - Watermelon, Seedless	" },
                    new InvoiceItemModel() { ID = 75, IvoiceID = 1, Amount = 41, Price = 4.81f, ProductName = "	Cucumber - English	" },
                    new InvoiceItemModel() { ID = 76, IvoiceID = 4, Amount = 94, Price = 74.74f, ProductName = "	Muffin Carrot - Individual	" },
                    new InvoiceItemModel() { ID = 77, IvoiceID = 2, Amount = 57, Price = 47.1f, ProductName = "	Soup - Knorr, Ministrone	" },
                    new InvoiceItemModel() { ID = 78, IvoiceID = 3, Amount = 37, Price = 26.21f, ProductName = "	Halibut - Fletches	" },
                    new InvoiceItemModel() { ID = 79, IvoiceID = 2, Amount = 14, Price = 41.65f, ProductName = "	Sachet	" },
                    new InvoiceItemModel() { ID = 80, IvoiceID = 3, Amount = 25, Price = 78.32f, ProductName = "	Oil - Avocado	" },
                    new InvoiceItemModel() { ID = 81, IvoiceID = 4, Amount = 63, Price = 62.63f, ProductName = "	Coffee - French Vanilla Frothy	" },
                    new InvoiceItemModel() { ID = 82, IvoiceID = 1, Amount = 14, Price = 61.45f, ProductName = "	Lemon Grass	" },
                    new InvoiceItemModel() { ID = 83, IvoiceID = 2, Amount = 68, Price = 40.33f, ProductName = "	Nestea - Iced Tea	" },
                    new InvoiceItemModel() { ID = 84, IvoiceID = 2, Amount = 89, Price = 5.22f, ProductName = "	Cleaner - Pine Sol	" },
                    new InvoiceItemModel() { ID = 85, IvoiceID = 5, Amount = 87, Price = 77.8f, ProductName = "	Chips - Assorted	" },
                    new InvoiceItemModel() { ID = 86, IvoiceID = 4, Amount = 59, Price = 74.67f, ProductName = "	Squid Ink	" },
                    new InvoiceItemModel() { ID = 87, IvoiceID = 1, Amount = 6, Price = 20.95f, ProductName = "	Flower - Daisies	" },
                    new InvoiceItemModel() { ID = 88, IvoiceID = 3, Amount = 46, Price = 89.72f, ProductName = "	Pork - Belly Fresh	" },
                    new InvoiceItemModel() { ID = 89, IvoiceID = 4, Amount = 98, Price = 58.51f, ProductName = "	Arctic Char - Fresh, Whole	" },
                    new InvoiceItemModel() { ID = 90, IvoiceID = 2, Amount = 48, Price = 18.61f, ProductName = "	Cakes Assorted	" },
                    new InvoiceItemModel() { ID = 91, IvoiceID = 1, Amount = 48, Price = 20.79f, ProductName = "	Table Cloth - 53x69 Colour	" },
                    new InvoiceItemModel() { ID = 92, IvoiceID = 4, Amount = 55, Price = 30.0f, ProductName = "	Cheese - Brie Roitelet	" },
                    new InvoiceItemModel() { ID = 93, IvoiceID = 5, Amount = 79, Price = 16.36f, ProductName = "	Wine - Cotes Du Rhone Parallele	" },
                    new InvoiceItemModel() { ID = 94, IvoiceID = 5, Amount = 94, Price = 18.8f, ProductName = "	Juice - Clam, 46 Oz	" },
                    new InvoiceItemModel() { ID = 95, IvoiceID = 2, Amount = 67, Price = 50.93f, ProductName = "	Smoked Paprika	" },
                    new InvoiceItemModel() { ID = 96, IvoiceID = 3, Amount = 52, Price = 8.28f, ProductName = "	Steampan - Half Size Shallow	" },
                    new InvoiceItemModel() { ID = 97, IvoiceID = 5, Amount = 20, Price = 85.42f, ProductName = "	Pail With Metal Handle 16l White	" },
                    new InvoiceItemModel() { ID = 98, IvoiceID = 2, Amount = 76, Price = 7.12f, ProductName = "	Flour - Buckwheat, Dark	" },
                    new InvoiceItemModel() { ID = 99, IvoiceID = 5, Amount = 29, Price = 68.14f, ProductName = "	Bagel - Whole White Sesame	" },
                    new InvoiceItemModel() { ID = 100, IvoiceID = 4, Amount = 31, Price = 26.09f, ProductName = "	Bread - Sticks, Thin, Plain	" },
                    new InvoiceItemModel() { ID = 101, IvoiceID = 4, Amount = 93, Price = 81.67f, ProductName = "	Pumpkin	" },
                    new InvoiceItemModel() { ID = 102, IvoiceID = 3, Amount = 80, Price = 48.09f, ProductName = "	Carbonated Water - Blackberry	" },
                    new InvoiceItemModel() { ID = 103, IvoiceID = 1, Amount = 45, Price = 44.76f, ProductName = "	Muffins - Assorted	" },
                    new InvoiceItemModel() { ID = 104, IvoiceID = 2, Amount = 76, Price = 84.54f, ProductName = "	Lettuce - Baby Salad Greens	" },
                    new InvoiceItemModel() { ID = 105, IvoiceID = 2, Amount = 20, Price = 8.17f, ProductName = "	Oil - Sunflower	" },
                    new InvoiceItemModel() { ID = 106, IvoiceID = 4, Amount = 76, Price = 28.36f, ProductName = "	Veal - Round, Eye Of	" },
                    new InvoiceItemModel() { ID = 107, IvoiceID = 5, Amount = 25, Price = 66.08f, ProductName = "	Flour - Strong	" },
                    new InvoiceItemModel() { ID = 108, IvoiceID = 5, Amount = 11, Price = 77.99f, ProductName = "	Wine - Magnotta, Merlot Sr Vqa	" },
                    new InvoiceItemModel() { ID = 109, IvoiceID = 2, Amount = 2, Price = 48.58f, ProductName = "	Chocolate - Semi Sweet	" },
                    new InvoiceItemModel() { ID = 110, IvoiceID = 2, Amount = 99, Price = 81.33f, ProductName = "	Pepper - Green Thai	" },
                    new InvoiceItemModel() { ID = 111, IvoiceID = 5, Amount = 28, Price = 57.48f, ProductName = "	Cheese - Woolwich Goat, Log	" },
                    new InvoiceItemModel() { ID = 112, IvoiceID = 2, Amount = 11, Price = 14.03f, ProductName = "	Muffin Batt - Carrot Spice	" },
                    new InvoiceItemModel() { ID = 113, IvoiceID = 1, Amount = 99, Price = 38.98f, ProductName = "	Bread - Bistro Sour	" },
                    new InvoiceItemModel() { ID = 114, IvoiceID = 2, Amount = 94, Price = 98.08f, ProductName = "	Rice - Brown	" },
                    new InvoiceItemModel() { ID = 115, IvoiceID = 3, Amount = 29, Price = 40.92f, ProductName = "	Pears - Anjou	" },
                    new InvoiceItemModel() { ID = 116, IvoiceID = 2, Amount = 59, Price = 54.2f, ProductName = "	Flour - Corn, Fine	" },
                    new InvoiceItemModel() { ID = 117, IvoiceID = 4, Amount = 20, Price = 87.87f, ProductName = "	Water - Perrier	" },
                    new InvoiceItemModel() { ID = 118, IvoiceID = 1, Amount = 6, Price = 25.74f, ProductName = "	Gelatine Leaves - Envelopes	" },
                    new InvoiceItemModel() { ID = 119, IvoiceID = 1, Amount = 8, Price = 46.43f, ProductName = "	Muffin Batt - Carrot Spice	" },
                    new InvoiceItemModel() { ID = 120, IvoiceID = 4, Amount = 34, Price = 73.94f, ProductName = "	Phyllo Dough	" },
                    new InvoiceItemModel() { ID = 121, IvoiceID = 5, Amount = 3, Price = 23.32f, ProductName = "	Pears - Bosc	" },
                    new InvoiceItemModel() { ID = 122, IvoiceID = 2, Amount = 22, Price = 76.17f, ProductName = "	Sauce - Fish 25 Ozf Bottle	" },
                    new InvoiceItemModel() { ID = 123, IvoiceID = 2, Amount = 22, Price = 83.75f, ProductName = "	Strawberries - California	" },
                    new InvoiceItemModel() { ID = 124, IvoiceID = 2, Amount = 82, Price = 47.63f, ProductName = "	Pasta - Tortellini, Fresh	" },
                    new InvoiceItemModel() { ID = 125, IvoiceID = 3, Amount = 27, Price = 59.11f, ProductName = "	Beef - Montreal Smoked Brisket	" },
                    new InvoiceItemModel() { ID = 126, IvoiceID = 4, Amount = 84, Price = 83.06f, ProductName = "	Cookies Cereal Nut	" },
                    new InvoiceItemModel() { ID = 127, IvoiceID = 4, Amount = 60, Price = 62.41f, ProductName = "	Worcestershire Sauce	" },
                    new InvoiceItemModel() { ID = 128, IvoiceID = 2, Amount = 72, Price = 16.46f, ProductName = "	Wine - Barbera Alba Doc 2001	" },
                    new InvoiceItemModel() { ID = 129, IvoiceID = 2, Amount = 30, Price = 83.7f, ProductName = "	Venison - Striploin	" },
                    new InvoiceItemModel() { ID = 130, IvoiceID = 4, Amount = 55, Price = 26.29f, ProductName = "	Galliano	" },
                    new InvoiceItemModel() { ID = 131, IvoiceID = 1, Amount = 74, Price = 72.52f, ProductName = "	Bread - Flat Bread	" },
                    new InvoiceItemModel() { ID = 132, IvoiceID = 4, Amount = 96, Price = 54.55f, ProductName = "	Soap - Hand Soap	" },
                    new InvoiceItemModel() { ID = 133, IvoiceID = 4, Amount = 47, Price = 46.02f, ProductName = "	Tomatoes - Yellow Hot House	" },
                    new InvoiceItemModel() { ID = 134, IvoiceID = 3, Amount = 27, Price = 86.08f, ProductName = "	Milk 2% 500 Ml	" },
                    new InvoiceItemModel() { ID = 135, IvoiceID = 2, Amount = 16, Price = 43.96f, ProductName = "	Glove - Cutting	" },
                    new InvoiceItemModel() { ID = 136, IvoiceID = 3, Amount = 74, Price = 5.07f, ProductName = "	Cake - Pancake	" }
                );
            dbContext.SaveChanges();
        }

    }
}

