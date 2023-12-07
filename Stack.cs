using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> items = new List<T>();

    public void Push(T item) => items.Add(item);

    public T Pop() =>  items.RemoveLast();

    public T Peek() =>  items[^1];

    public bool IsEmpty() => items.Count == 0;
}

public static class ListExtensions
{
    public static T RemoveLast<T>(this List<T> list)
    {
        int lastIndex = list.Count - 1;
        T lastItem = list[lastIndex];
        list.RemoveAt(lastIndex);
        return lastItem;
    }
}
