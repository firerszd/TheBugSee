using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SeeBug
{
    public class CCEditorBtnAttribute : Attribute
    {
        public string Name { get; set; } = string.Empty;

        public CCEditorBtnAttribute()
        {

        }

        public CCEditorBtnAttribute(string name)
        {
            this.Name = name;
        }
    }
}