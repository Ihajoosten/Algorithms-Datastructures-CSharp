using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class MusicCollection
    {
        private List<Song> collection = new List<Song>();


        public void Add(Song newSong)
        {
            collection.Add(newSong);
        }


        public int Size()
        {
            return collection.Count;
        }

        public void PrintSongTitle()
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.Title);
            }
        }


        public void SortTitle()
        {
            collection.Sort(new TitleComparer());
            Console.WriteLine(collection);
        }

        public void SortPerformer()
        {
            collection.Sort(new PerformerComparer());
            Console.WriteLine(collection);
        }

        public void SortDuration()
        {
            collection.Sort(new DurationComparer());
            Console.WriteLine(collection);
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Performer { get; set; }
        public int Duration { get; set; }
    }

    public class TitleComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

    public class PerformerComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.Performer.CompareTo(y.Performer);
        }
    }

    public class DurationComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.Duration.CompareTo(y.Duration);
        }
    }

}


