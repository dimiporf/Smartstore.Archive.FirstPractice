using Microsoft.AspNetCore.Mvc;
using Smartstore.Web.Controllers;
using System.Collections.Generic;
using System;
using System.Xml.Linq;
using Smartstore.HelloWorld.Models;

namespace Smartstore.HelloWorld.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            var rssFeedPath = "C:\\Users\\dimip\\Desktop\\newsfeed.xml"; // Replace with the actual path

            var newsItems = ReadRssFeed(rssFeedPath);

            var viewModel = new List<NewsItemModel>(newsItems);

            return View(viewModel);
        }

        private List<NewsItemModel> ReadRssFeed(string rssFeedPath)
        {
            var newsItems = new List<NewsItemModel>();

            try
            {
                var xmlDoc = XDocument.Load(rssFeedPath);

                foreach (var item in xmlDoc.Descendants("item"))
                {
                    var guid = item.Element("guid")?.Value;
                    var link = item.Element("link")?.Value;
                    var title = item.Element("title")?.Value;
                    var description = item.Element("description")?.Value;
                    var imageUrl = item.Element("enclosure")?.Attribute("url")?.Value;

                    if (!string.IsNullOrEmpty(guid) && !string.IsNullOrEmpty(link) &&
                        !string.IsNullOrEmpty(title))
                    {
                        var newsItem = new NewsItemModel
                        {
                            Guid = guid,
                            Link = link,
                            Title = title,
                            Description = description,
                            ImageUrl = imageUrl
                        };

                        newsItems.Add(newsItem);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log, display an error message, etc.)
                // For simplicity, we are not handling exceptions thoroughly in this example
            }

            return newsItems;
        }
    }
}
