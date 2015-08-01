﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Soukoku.Owin.Files.Services
{
    /// <summary>
    /// Interface for getting <see cref="IResource"/>s.
    /// </summary>
    public interface IReadOnlyDataStore
    {
        /// <summary>
        /// Gets the resource at the specified logical path.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="logicalPath">The logical path.</param>
        /// <returns></returns>
        ResourceResult GetResource(Context context, string logicalPath);

        /// <summary>
        /// Gets the resources under a collection resource.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="parentFolder">The parent folder.</param>
        /// <returns></returns>
        IEnumerable<ResourceResult> GetSubResources(Context context, IResource parentFolder);

        /// <summary>
        /// Opens the the resource stream for reading if applicable.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <returns></returns>
        Stream Open(IResource resource);

    }


    public class ResourceResult
    {
        public ResourceResult()
        {
            Code = HttpStatusCode.OK;
        }

        public HttpStatusCode Code { get; set; }

        public IResource Resource { get; set; }
    }
}
