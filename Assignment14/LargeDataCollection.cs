using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    
        public class LargeDataCollection<T> : IDisposable
        {
            private List<T> internalData; // List to hold data of any type

            // Constructor to initialize the collection with initial data
            public LargeDataCollection(IEnumerable<T> initialData)
            {
                internalData = new List<T>(initialData);
            }

            public void AddElement(T element)
            {
                internalData.Add(element);
            }
            public void RemoveElement(T element)
            {
                internalData.Remove(element);
            }
            public void AccessElements()
            {
                foreach (var element in internalData)
                {
                    Console.WriteLine(element);
                }
            }

            // Implementing the IDisposable interface
            public void Dispose()
            {
                // Set the internal data structure to null to free up memory
                internalData = null;
                // Dispose method is called explicitly to release resources
                GC.SuppressFinalize(this);
            }
        }
    }


