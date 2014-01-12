using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCalculations
/// </summary>
public class clsCalculations
{
    public clsCalculations()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public decimal Average
    {
        get
        {
            clsSimpleDataConnection DataLayer = new clsSimpleDataConnection();
            List<Decimal> ArrayList = new List<decimal>();
            ArrayList = DataLayer.LoadDecimalList();
            Decimal AnItem;
            Decimal Total = 0;
            Int32 Count;
            Decimal Average;
            Count = ArrayList.Count;
            Int32 Index = 0;
            while (Index < Count)
            {
                AnItem = ArrayList[Index];
                Total = Total + AnItem;
                Index++;
            }
            Average = Total / Count;
            return Average;
        }
    }
    public decimal Max
    {
        get
        {
            clsSimpleDataConnection DataLayer = new clsSimpleDataConnection();
            List<Decimal> ArrayList = new List<decimal>();
            ArrayList = DataLayer.LoadDecimalList();
            Decimal AnItem;
            Int32 Count;
            Decimal MaxValue;
            MaxValue = decimal.MinValue;
            Count = ArrayList.Count;
            Int32 Index = 0;
            while (Index < Count)
            {
                AnItem = ArrayList[Index];
                Index++;
                if (AnItem > MaxValue)
                {
                    MaxValue = AnItem;
                }
            }
            return MaxValue;
        }
    }
    public decimal Min
    {
        get
        {
            clsSimpleDataConnection DataLayer = new clsSimpleDataConnection();
            List<Decimal> ArrayList = new List<decimal>();
            ArrayList = DataLayer.LoadDecimalList();
            Decimal AnItem;
            Int32 Count;
            Decimal MinValue;
            MinValue = decimal.MaxValue;
            Count = ArrayList.Count;
            Int32 Index = 0;
            while (Index < Count)
            {
                AnItem = ArrayList[Index];
                Index++;
                if (AnItem < MinValue)
                {
                    MinValue = AnItem;
                }
            }
            return MinValue;
        }
    }
    public void Add(decimal Value)
    {
        clsSimpleDataConnection DataLayer = new clsSimpleDataConnection();
        List<Decimal> ArrayList = new List<decimal>();
        ArrayList = DataLayer.LoadDecimalList();
        ArrayList.Add(Value);
        DataLayer.SaveDecimalList(ArrayList);
    }
    public void Clear()
    {
        clsSimpleDataConnection DataLayer = new clsSimpleDataConnection();
        List<Decimal> ArrayList = new List<decimal>();
        DataLayer.SaveDecimalList(ArrayList);
    }
    public Int32 Count
    {
        get
        {
            clsSimpleDataConnection DataLayer = new clsSimpleDataConnection();
            List<Decimal> ArrayList = new List<decimal>();
            ArrayList = DataLayer.LoadDecimalList();
            return ArrayList.Count;
        }
    }

}
