using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstFloor.ModernUI.Presentation;
using Godlike.Model;


namespace Godlike.GUI.Content.ViewModels
{
    public class SetUpPathsViewModel : NotifyPropertyChanged
    {
        public List<MediaPath> GetMediaPaths()
        {
            List<MediaPath> mediaPaths = new List<MediaPath>();
            MediaPath mediaPath = new MediaPath();
            mediaPath.ComputerName = "hestehest";
            mediaPath.Path = @"X:\Move eaze";
            mediaPaths.Add(mediaPath);
            return mediaPaths;
        }
    }
}
