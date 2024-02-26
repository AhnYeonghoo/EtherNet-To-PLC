using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    class Configuration2
    {
        List<ItemValue> listConfig = new List<ItemValue>();
        public void SetConfiguration2(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfiguration2(string item)
        {
            foreach (ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }

        private class ItemValue
        {
            private string item;
            private string value;

            public string GetItem()
            {
                return item;
            }

            public string GetValue()
            {
                return value;
            }
            public void SetValue(Configuration2 config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    config.listConfig.Add(this);
                }


            }
        }


        internal class NestedClass
        {
            static void MainNestedClass()
            {
                Configuration2 config = new Configuration2();
                config.SetConfiguration2("Version", "V 5.0");
                config.SetConfiguration2("Size", "655.324 KB");

                Console.WriteLine(config.GetConfiguration2("Version"));
                Console.WriteLine(config.GetConfiguration2("Size"));

                config.SetConfiguration2("Version", "V 5.0.1");
                Console.WriteLine(config.GetConfiguration2("Version"));
            }
        }
    }

}