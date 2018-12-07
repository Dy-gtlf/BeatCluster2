using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class ScoreData {
    public string title { get; set;}
    public string description { get; set;}
    public string category { get; set;}
    public int bpm { get; set;}
    public int beats { get; set;}
    public int offset { get; set;}
    public Score scores { get; set;}

    public class Score {
        public List<ScoreDetail> easy { get; set;}
        public List<ScoreDetail> normal { get; set;}
        public List<ScoreDetail> hard { get; set;}
    }
    public class ScoreDetail {
        public int bpm { get; set;}
        public int beats { get; set;}
        public int measure { get; set;}
        public List<List<int>> notes { get; set;}
    }
}