using System.Collections;
using System.Collections.Generic;

public class CCFloatAttribute : CCButtonAttribute
{
    public float[] Ranges
    {
        get;
        set;
    }
    
    public CCFloatAttribute(string name)
    {
        this.Name = name;
    }
    
      
    public CCFloatAttribute(string name, int priority, float[] ranges)
    {
        this.Name = name;
        this.Priority = priority;
        this.Ranges = ranges;
    }
    
    public CCFloatAttribute(string name, int priority, int space, float[] ranges)
    {
        this.Name = name;
        this.Priority = priority;
        this.Space = space;
        this.Ranges = ranges;
    }
    
    public CCFloatAttribute(string name, string tip, int priority, int space, float[] ranges)
    {
        this.Name = name;
        this.Tip = tip;
        this.Priority = priority;
        this.Space = space;
        this.Ranges = ranges;
    }
}
