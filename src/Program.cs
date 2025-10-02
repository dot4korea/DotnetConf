using Statiq.App;
using Statiq.Common;
using Statiq.Web;
using Statiq.Markdown;

return await Bootstrapper
    .Factory
    .CreateWeb (args)
    .ConfigureSettings (settings =>
    {
        settings[Keys.LinkRoot] = "/conf";
        settings[Keys.LinksUseHttps] = false; // 필요시
    })
    .RunAsync ();