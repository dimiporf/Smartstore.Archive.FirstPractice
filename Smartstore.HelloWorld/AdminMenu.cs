using Smartstore.Collections;
using Smartstore.Core.Content.Menus;
using Smartstore.Web.Rendering.Builders;

namespace Smartstore.HelloWorld
{
    public class AdminMenu : AdminMenuProvider
    {
        protected override void BuildMenuCore(TreeNode<MenuItem> modulesNode)
        {
            var menuItem = new MenuItem().ToBuilder()
                .Text("Hello World Plugin")
                .ResKey("Plugins.SmartStore.HelloWorld.HelloButton")
                .Icon("gear", "bi")
                .Action("Configure", "HelloWorldAdmin", new { area = "Admin" })
                .AsItem();

            //var menuNode = new TreeNode<MenuItem>(menuItem);

            modulesNode.Append(menuItem);


            var rssFeedMenuItem = new MenuItem().ToBuilder()
                .Text("RSS Feed")
                .ResKey("Plugins.SmartStore.HelloWorld.RssFeedButton")
                .Icon("rss", "bi") // Use an appropriate RSS icon
                .Action("Index", "News", new { area = "Admin" }) // Specify the area
                .AsItem();

            modulesNode.Append(rssFeedMenuItem);

            //var refNode = modulesNode.Root.SelectNodeById("settings");
            //menuNode.InsertAfter(refNode);

            //var secondMenuItem = new MenuItem().ToBuilder()
            //   .ResKey("Plugins.SmartStore.HelloWorld.HelloMenuItem")
            //   .AsItem();
            //var subMenuItem = new MenuItem().ToBuilder()
            //    .ResKey("Plugins.SmartStore.HelloWorld.HelloSubMenuItem")
            //    .Action("Configure", "HelloWorldAdmin", new { area = "Admin" })
            //    .AsItem();

            //var secondMenuNode = new TreeNode<MenuItem>(secondMenuItem);
            //var subMenuNode = new TreeNode<MenuItem>(subMenuItem);

            //secondMenuNode.InsertAfter(menuNode);
            //secondMenuNode.Append(subMenuNode);




        }
    }
}
