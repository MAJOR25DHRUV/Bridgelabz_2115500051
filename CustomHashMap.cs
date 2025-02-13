using System;
using System.Collections.Generic;

public class CustomHashMap
{
    // Class to represent each entry in the hash map
    private class Entry
    {
        public int Key; // Stores the key
        public string Value; // Stores the value
        public Entry Next; // Pointer to handle collisions using chaining

        // Constructor to initialize an entry
        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    // Array to store the buckets (linked list heads)
    private Entry[] buckets;

    // Stores the number of elements in the hash map
    private int size;

    // Default capacity of the hash map
    private const int DEFAULT_CAPACITY = 16;

    // Constructor to initialize the hash map with default capacity
    public CustomHashMap()
    {
        buckets = new Entry[DEFAULT_CAPACITY];
        size = 0;
    }

    // Method to compute the index of a key in the buckets array
    private int GetBucketIndex(int key)
    {
        return Math.Abs(key.GetHashCode() % buckets.Length);
    }

    // Method to insert or update a key-value pair
    public void Put(int key, string value)
    {
        // Compute the bucket index for the key
        int bucketIndex = GetBucketIndex(key);

        // Get the first entry in the corresponding bucket
        Entry entry = buckets[bucketIndex];

        // Traverse the linked list to check if the key already exists
        while (entry != null)
        {
            // If key exists, update its value
            if (entry.Key == key)
            {
                entry.Value = value;
                return;
            }
            entry = entry.Next;
        }

        // Create a new entry and insert it at the beginning of the bucket's linked list
        Entry newEntry = new Entry(key, value);
        newEntry.Next = buckets[bucketIndex];
        buckets[bucketIndex] = newEntry;

        // Increase the size of the hash map
        size++;
    }

    // Method to retrieve the value associated with a key
    public string Get(int key)
    {
        // Compute the bucket index for the key
        int bucketIndex = GetBucketIndex(key);

        // Get the first entry in the corresponding bucket
        Entry entry = buckets[bucketIndex];

        // Traverse the linked list to find the key
        while (entry != null)
        {
            // If key matches, return its value
            if (entry.Key == key)
            {
                return entry.Value;
            }
            entry = entry.Next;
        }

        // Return null if key is not found
        return null;
    }

    // Method to remove a key-value pair from the hash map
    public void Remove(int key)
    {
        // Compute the bucket index for the key
        int bucketIndex = GetBucketIndex(key);

        // Get the first entry in the corresponding bucket
        Entry entry = buckets[bucketIndex];
        Entry prev = null;

        // Traverse the linked list to find the key
        while (entry != null)
        {
            // If key matches, remove the entry
            if (entry.Key == key)
            {
                // If the entry to be removed is the first in the bucket
                if (prev == null)
                {
                    buckets[bucketIndex] = entry.Next;
                }
                else
                {
                    prev.Next = entry.Next;
                }

                // Decrease the size of the hash map
                size--;
                return;
            }

            // Move to the next entry in the linked list
            prev = entry;
            entry = entry.Next;
        }
    }

    public static void Main(string[] args)
    {
        // Create a new instance of CustomHashMap
        CustomHashMap map = new CustomHashMap();
        
        // Insert key-value pairs into the hash map
        map.Put(1, "One");
        map.Put(2, "Two");
        map.Put(3, "Three");

        // Retrieve and print values for specific keys
        Console.WriteLine("Value for key 1: " + map.Get(1));
        Console.WriteLine("Value for key 2: " + map.Get(2));

        // Remove a key-value pair
        map.Remove(2);
        Console.WriteLine("Value for key 2 after removal: " + map.Get(2));

        // Update the value for an existing key
        map.Put(1, "New One");
        Console.WriteLine("Updated value for key 1: " + map.Get(1));
    }
}
