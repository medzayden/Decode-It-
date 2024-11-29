using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Dictionary<Tuple<char, int>, string> data = new Dictionary<Tuple<char, int>, string>();
    [SerializeField] private Dictionary<char, string> mizo = new Dictionary<char, string>();
    [SerializeField] private Hashtable mizoCache = new Hashtable();
    [SerializeField] private HashSet<char> mizo2 = new HashSet<char>();
    [SerializeField] private Tuple<char, int> zizo =  new Tuple<char, int>( 'X',5 ) ;
    [SerializeField] private int x;
  
    public Tuple<int, int>[] X = new Tuple<int, int>[5];
    private void Start()
    {/*
        data.Add(5, "mzoughi");
        data.Add(15619, "duohaoidja");
        data.Add(14, "haha");*/
        //data.Add(5, "jijdpa");

       // Debug.Log(mizo[0].ToString());
        Debug.Log(zizo.Item1);
        
    
      
    }
     
}
