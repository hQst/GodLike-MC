using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using FirstFloor.ModernUI.Presentation;
using Godlike.Model;
using System.ComponentModel;
using BinaryRage;

namespace Godlike.GUI.Content.ViewModels
{
    public class SetUpPathsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<MediaPath> _MediaPaths;

        public ObservableCollection<MediaPath> MediaPaths
        {
            get { return _MediaPaths; }
            set { _MediaPaths = value; OnPropertyChanged(value); }
        }

        public void MediaPathsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //This will get called when the collection is changed
            string ComputerName = _MediaPaths[0].ComputerName;
            string Path = _MediaPaths[0].Path;
            //BinaryRage.DB<MediaPath>.Insert("", _MediaPaths, "");
        }

        public void hesst<T>(T hest)
        {

        }

        //public ObservableCollection<MediaPath> MediaPaths
        //{
        //    get { return GetMediaPaths(); }
        //    set
        //    {
        //        //MediaPaths = value;
        //        OnPropertyChanged(value);
        //    }
        //}

        public SetUpPathsViewModel()
        {
            _MediaPaths = GetMediaPaths();
            _MediaPaths.CollectionChanged += MediaPathsChanged;
        }

        public void SetMediaPath(ObservableCollection<MediaPath> mediaPaths)
        {

        }

        public ObservableCollection<MediaPath> GetMediaPaths()
        {
            var mediaPaths = new ObservableCollection<MediaPath>();
            mediaPaths.Add(new MediaPath { ComputerName = "hestehest", Path = "denherpath" });

            return mediaPaths;
        }

        protected void OnPropertyChanged(ObservableCollection<MediaPath> name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                //handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
