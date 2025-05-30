using Microsoft.Extensions.DependencyInjection;
using OrchardCore.AdminMenu.AdminNodes;
using OrchardCore.AdminMenu.Deployment;
using OrchardCore.AdminMenu.Recipes;
using OrchardCore.AdminMenu.Services;
using OrchardCore.Deployment;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Recipes;
using OrchardCore.Security.Permissions;

namespace OrchardCore.AdminMenu;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddPermissionProvider<Permissions>();
        services.AddNavigationProvider<AdminMenu>();

#pragma warning disable CS0618 // Type or member is obsolete
        services.AddScoped<IAdminMenuPermissionService, AdminMenuPermissionService>();
#pragma warning restore CS0618 // Type or member is obsolete

        services.AddScoped<IAdminMenuService, AdminMenuService>();
        services.AddScoped<AdminMenuNavigationProvidersCoordinator>();

        services.AddRecipeExecutionStep<AdminMenuStep>();

        services.AddDeployment<AdminMenuDeploymentSource, AdminMenuDeploymentStep, AdminMenuDeploymentStepDriver>();

        // placeholder treeNode
        services.AddAdminNode<PlaceholderAdminNode, PlaceholderAdminNodeNavigationBuilder, PlaceholderAdminNodeDriver>();

        // link treeNode
        services.AddAdminNode<LinkAdminNode, LinkAdminNodeNavigationBuilder, LinkAdminNodeDriver>();
    }
}
