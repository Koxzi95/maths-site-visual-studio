using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsSimpleDataConnection
{
    ///#########################################################################
    ///#########################################################################
    ///the code below defines methods for use in phase test 1
    ///it needs to be copied into a class file called clsSimpleDataConnection replacing all of the default code
    ///you will need these functions to make sure that your data is saved to the data layer
    ///this code will be made available on the day of the test
    ///
    ///there are two pairs of functions 
    ///if the data you are working with is decimal then use LoadDecimalList and SaveDecimalList
    ///if the data is integer then use LoadIntegerList and SaveIntegerList


    //var to store the name of the database file
    private string DBName;

    //constructor
    public clsSimpleDataConnection()
    {
        //get the path of this web site
        string DbPath = System.AppDomain.CurrentDomain.BaseDirectory;
        //set the path and name of the database
        DBName = DbPath + "App_Data\\temp.txt";
    }

    ///#########################################################################
    //these are the two methods if you are using decimal data

    ///the first method saves the data in your decimal array list
    ///it accepts one parameter an array list of type decimal called some data
    public void SaveDecimalList(List<decimal> SomeData)
    {
        //temp list to store the data
        List<string> TempList = new List<string>();
        //var to store index initialised to zero
        Int32 Index = 0;
        //temp string var
        string Temp;
        //while there are records to process
        while (Index < SomeData.Count)
        {
            //get an item at position index
            Temp = Convert.ToString(SomeData[Index]);
            //add it to the temp list
            TempList.Add(Temp);
            //increment the index
            Index++;
        }
        //process the temp list
        WriteData(TempList);
    }

    ///this method loads the data for a decimal list
    ///it returns an array list of type decimal
    public List<decimal> LoadDecimalList()
    {
        //temp list
        List<string> TempList = new List<string>();
        //list to store the final data
        List<decimal> SomeData = new List<decimal>();
        //get the data from the text file
        TempList = LoadData();
        //var for index initialised to zero
        Int32 Index = 0;
        //temp var for a single item
        decimal Temp;
        //while there are record to process
        while (Index < TempList.Count)
        {
            //read a single item at position index
            Temp = Convert.ToDecimal(TempList[Index]);
            //add to to the list of data
            SomeData.Add(Temp);
            //increment the index
            Index++;
        }
        //return the data
        return SomeData;
    }

    ///#########################################################################
    ///#########################################################################
    //these are the two methods if you are using integer data

    ///the first method saves the data in your integer array list
    ///it accepts one parameter an array list of type integer called some data
    public void SaveIntegerList(List<Int32> SomeData)
    {
        //temp list to store the data
        List<string> TempList = new List<string>();
        //var to store index initialised to zero
        Int32 Index = 0;
        //temp string var
        string Temp;
        //while there are records to process
        while (Index < SomeData.Count)
        {
            //get an item at position index
            Temp = Convert.ToString(SomeData[Index]);
            //add it to the temp list
            TempList.Add(Temp);
        }
        //process the temp list
        WriteData(TempList);
    }

    ///this method loads the data for an integer list
    ///it returns an array list of type integer
    public List<Int32> LoadIntegerList()
    {
        //temp list
        List<string> TempList = new List<string>();
        //list to store the final data
        List<Int32> SomeData = new List<Int32>();
        //get the data from the text file
        TempList = LoadData();
        //var for index initialised to zero
        Int32 Index = 0;
        //temp var for a single item
        Int32 Temp;
        //while there are record to process
        while (Index < TempList.Count)
        {
            //read a single item at position index
            Temp = Convert.ToInt32(TempList[Index]);
            //add to to the list of data
            SomeData.Add(Temp);
        }
        //return the data
        return SomeData;
    }

    ///#########################################################################


    private void WriteData(List<string> SomeData)
    {
        //var to store a single item of data
        string AnEntry;
        //create the data source file temp.txt
        System.IO.StreamWriter DataSource = new System.IO.StreamWriter(DBName);
        //index for the loop
        Int32 Index = 0;
        //while there are items to process
        while (Index < SomeData.Count)
        {
            //get an entry from the list
            AnEntry = SomeData[Index];
            //write that as a line in the text file
            DataSource.WriteLine(AnEntry);
            //increment the index
            Index++;
        }
        //close the data source
        DataSource.Close();
    }

    private List<string> LoadData()
    {
        //create a temporary array list of type decimal
        List<string> TempData = new List<string>();
        //var to store a single entry of data
        string AnEntry;
        //if the database file exists
        if (System.IO.File.Exists(DBName) == true)
        {
            //open the file for reading
            System.IO.StreamReader DataSource = new System.IO.StreamReader(DBName);
            //while there are entrie sto process
            while (DataSource.Peek() > -1)
            {
                //get a single entry
                AnEntry = DataSource.ReadLine();
                //add the entry to the temporary list
                TempData.Add(AnEntry);
            }
            //close the connection
            DataSource.Close();
        }
        //return the temp array list
        return TempData;
    }

    ///#########################################################################
    ///#########################################################################
}