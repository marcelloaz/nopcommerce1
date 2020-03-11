using System.Collections.Generic;
using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.PromoSlider
{
    public class NovoSliderPlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => throw new System.NotImplementedException();

        public string GetWidgetViewComponentName(string widgetZone)
        {
            throw new System.NotImplementedException();
        }

        public IList<string> GetWidgetZones()
        {
            throw new System.NotImplementedException();
        }
    }
}
