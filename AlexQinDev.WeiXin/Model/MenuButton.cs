using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace AlexQinDev.WeiXin.Model
{
    public class MenuButton
    {
        public MenuButton()
        {
            this.Button = new List<object>();
        }

        [JsonProperty("button")]
        public List<object> Button { get; set; }
    }

    public class ClickButton
    {
        public ClickButton()
        {
            this.Type = "click";
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class ViewButton
    {
        public ViewButton()
        {
            this.Type = "view";
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SubButton
    {
        public SubButton()
        {
            this.Sub_Button = new List<object>();
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sub_button")]
        public List<object> Sub_Button { get; set; }
    }
}
