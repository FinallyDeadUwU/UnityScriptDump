using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListCompare
{
    //How can i use this script? ListCompare.CompareLists<Component>(list1, list2);
    
    public static bool CompareLists<T>(List<T> TryToMatch, List<T> MatchList) //return true == yeah, they are same, return false == no, they are not same or in wrong order..
    {
        if (TryToMatch.Count != MatchList.Count) //If list count don't match.
        {
            return false;
        }

        foreach (var item in TryToMatch)  //Search for all items. If a list contains the same items, and it's in the right order,.
        {
            if (MatchList.Contains(item) && AreListsEqual(TryToMatch, MatchList)) // If a lists contains the same items, and it's in the right order,.
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        return false;

    }

    public static bool AreListsEqual<T>(List<T> list1, List<T> list2) //Check if items are in right order. You can use this static bool too without using CompareLists.
    {
        if (list1.Count != list2.Count)
        {
            return false;
        }

        for (int i = 0; i < list1.Count; i++)
        {
            if (!EqualityComparer<T>.Default.Equals(list1[i], list2[i])) 
            {
                return false;
            }
        }

        return true;
    }
}
