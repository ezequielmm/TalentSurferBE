using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EY.TalentSurfer.Support.Api.Contracts
{
    public interface IPageLinkBuilder
    {
        Dictionary<string, string> Build(IUrlHelper url, string routeName, int pageNum, int pageSize, int pagesCount);
    }
}
