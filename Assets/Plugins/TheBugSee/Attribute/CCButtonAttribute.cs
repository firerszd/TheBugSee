using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SeeBug
{
    public class CCButtonAttribute : Attribute
    {
        public string Name { get; set; }

        public string Tip { get; set; }

        public int Priority { get; set; }

        public object[] ObjV { get; set; }

        public int Space { get; set; } = 2;

        public CCButtonAttribute()
        {

        }

        public CCButtonAttribute(string name)
        {
            this.Name = name;
        }

        public CCButtonAttribute(string name, int priority, string tip = "", params object[] canshu)
        {
            this.Name = name;
            this.Priority = priority;
            this.Tip = tip;
            this.ObjV = canshu;
        }

        public CCButtonAttribute(string name, int priority, int space, string tip = "", params object[] canshu)
        {
            this.Name = name;
            this.Priority = priority;
            this.Tip = tip;
            this.Space = space;
            this.ObjV = canshu;
        }

        public CCButtonAttribute(string name, string tip)
        {
            this.Name = name;
            this.Tip = tip;
        }

        public CCButtonAttribute(string name, string tip, params object[] canshu)
        {
            this.Name = name;
            this.Tip = tip;
            this.ObjV = canshu;
        }

    }
}