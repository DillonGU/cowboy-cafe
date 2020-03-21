using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    /// <summary>
    /// extension method class
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// finds the first ancestor in the cisual tree thta has the specifired type, 
        /// or null if no ancestor is frund
        /// </summary>
        /// <typeparam name="T">th etype t search for</typeparam>
        /// <param name="obj"></param>
        /// <returns>the first ancenstpr</returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent is null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent);
        }
    }
}
