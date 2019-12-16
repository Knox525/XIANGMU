namespace WebApplication.Migrations
{
    using System.Data.Entity.Migrations;
    using WebApplication.Models.Seeds;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication.Models.lclEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication.Models.lclEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            new ActionLinkCreator(context).Seed();
            new SideBarCreator(context).Seed();
            new UserCreator(context).Seed();
        }
    }
}
