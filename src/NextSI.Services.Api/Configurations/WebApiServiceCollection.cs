namespace NextSI.Services.Api.Configurations
{
    //public static class WebApiServiceCollectionExtensions
    //{
    //    public static IMvcCoreBuilder AddWebApi(this IServiceCollection services)
    //    {
    //        if (services == null) throw new ArgumentNullException(nameof(services));

    //        var builder = services.AddMvcCore();
    //        //builder.AddJsonFormatters();
    //        builder.AddJsonOptions(o =>
    //        {
    //            o.JsonSerializerOptions.PropertyNamingPolicy = null;
    //            o.JsonSerializerOptions.DictionaryKeyPolicy = null;
    //        });
    //        builder.AddApiExplorer();
    //        builder.AddCors();

    //        return new MvcCoreBuilder(builder.Services, builder.PartManager);
    //    }

    //    public static IMvcBuilder AddWebApi(this IServiceCollection services, Action<MvcOptions> setupAction)
    //    {
    //        if (services == null) throw new ArgumentNullException(nameof(services));
    //        if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

    //        var builder = services.AddWebApi();
    //        builder.Services.Configure(setupAction);

    //        return builder;
    //    }

    //}
}