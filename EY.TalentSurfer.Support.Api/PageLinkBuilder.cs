using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EY.TalentSurfer.Support.Api
{
    public class PageLinkBuilder : IPageLinkBuilder
    {
        public Dictionary<string, string> Build(IUrlHelper url, string routeName, int pageNum, int pageSize, int pagesCount)
        {
            var links = new Dictionary<string, string>();

            links.Add("FirstPage", url.Link(routeName, new { pageNum = 1, pageSize }));
            links.Add("LastPage", url.Link(routeName, new { pageNum = pagesCount, pageSize }));
            if (pageNum > 1) links.Add("PreviousPage", url.Link(routeName, new { pageNum = pageNum - 1, pageSize }));
            if (pageNum < pagesCount) links.Add("NextPage", url.Link(routeName, new { pageNum = pageNum + 1, pageSize }));

            return links;
        }
    }
}
