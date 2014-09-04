﻿//Contributor: http://aspnetadvimage.codeplex.com/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DIPSky.Web.Framework.UI.Editor
{
    /// <summary>
    /// NetAdv image service
    /// </summary>
    public class NetAdvImageService : INetAdvImageService
    {
        /// <summary>
        /// Gets a list of top-level images within a given directory
        /// </summary>
        /// <param name="path">Path</param>
        /// <param name="ctx">HTTP context</param>
        /// <returns>A lit of images</returns>
        public virtual IEnumerable<NetAdvImage> GetImages(string path, HttpContextBase ctx)
        {
            return

                from img in Directory.GetFiles(path)
                // Limit file types to images only
                where NetAdvImageSettings.AllowedFileTypes.Any(ext => img.EndsWith(ext, StringComparison.OrdinalIgnoreCase))
                select new NetAdvImage
                {
                    FileName = Path.GetFileName(img),
                    // The image object will be used by the client, so we'll need a relative path instead of a physical path
                    Path = ctx.Request.Url.AbsoluteUri.Replace(ctx.Request.Url.PathAndQuery, String.Empty) +
                           (ctx.Request.ApplicationPath.Equals("/") ? String.Empty : ctx.Request.ApplicationPath) +
                           img.Replace(ctx.Server.MapPath("~/"), "/").Replace(@"\", "/")
                };
        }

        /// <summary>
        /// Deletes a image
        /// </summary>
        /// <param name="path">Path</param>
        /// <param name="name">Name</param>
        /// <returns>Error (if happens)</returns>
        public virtual string DeleteImage(string path, string name)
        {
            try
            {
                string imgToDelete = Path.Combine(path, name);
                var fileExtension = Path.GetExtension(imgToDelete);
                if (!NetAdvImageSettings.AllowedFileTypes.Contains(fileExtension))
                    throw new Exception(string.Format("Files with {0} extension cannot be deleted", fileExtension));

                if (!File.Exists(imgToDelete))
                    throw new Exception("Image does not exist");

                // Delete it!
                File.Delete(imgToDelete);
                return null;
            }
            catch (Exception ex)
            {
                // Return the error message to be alerted.
                return ex.Message;
            }
        }
    }
}