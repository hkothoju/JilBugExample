using System;
using System.Collections.Generic;
using System.Text;

namespace TestClasses
{
   public class InheritedExampleGeneric : ExampleGeneric<InheritedDocumentLevel2> { }

   public class ExampleGeneric<T>
   {
      public IEnumerable<T> listOfObjects;
   }

   public class InheritedDocumentLevel2 : InheritedDocumentLevel1
   {
      public string template;
      public ExampleEnum3 enumValue;
      public ExampleSubClass3 exampleObject;
      public List<EnumExample2> listOfEnums;
      public IEnumerable<ExampleSubClass4> listOfObjects4;
      public List<ExampleSubClass5> listOfObjects5;
      public List<ExampleSubClass6> listOfObjects6;
   }

   public class InheritedDocumentLevel1 : BaseDocumentExample1
   {
      public IEnumerable<ExampleSubClass2> listOfObjects2;
   }

   public class BaseDocumentExample1
   {
      public string example1;
      public string example2;
      public string example3;
      public string example4;
      public string example5;
      public string example6;
      public string example7;
      public string example8;
      public string example9;
      public string example10;
      public double example11;
      public string example12;
      public string example13;
      public bool exampleBool;
      public IEnumerable<int> intList;
      public Dictionary<string, List<string>> dictionaryOfList1;
      public EnumExample1 someEnum1;
      public IEnumerable<ExampleSubClass1> listOfObjects1;
   }

   public enum EnumExample1
   {
      Example1, Example2
   }

   public enum EnumExample2
   {
      Example1, Example2, Example3
   }

   public enum ExampleEnum3
   {
      Example1, Example2
   }

   public class ExampleSubClass1
   {
      public int exampleIntValue1 { get; set; }
      public int exampleIntValue2 { get; set; }
      public IEnumerable<string> someStringList { get; set; }
   }


   public class ExampleSubClass2
   {
      public string example1 { get; set; }
      public string example2 { get; set; }
   }

   public class ExampleSubClass3
   {
      public string example1 { get; set; }
      public string example2 { get; set; }
   }

   public class ExampleSubClass4
   {
      public string example1 { get; set; }
      public string example2 { get; set; }
   }

   public class ExampleSubClass5
   {
      public string example1 { get; set; }
      public string example2 { get; set; }
      public bool someBool { get; set; }
      public List<string> listOfStrings;
      public List<ExampleSubClass7> listOfObjects7;
   }

   public class ExampleSubClass6
   {
      public int exampleInt1 { get; set; }
      public string example1 { get; set; }
      public string example2 { get; set; }
      public string example3 { get; set; }
      public List<string> listOfStrings { get; set; }

      public List<ExampleSubClass8> listOfObjects8;
      public IDictionary<string, IDictionary<string, string>> dictionaryOfDictionary { get; set; }
   }

   public class ExampleSubClass7
   {
      public string example1 { get; set; }
      public List<string> listOfStrings { get; set; }
   }

   public class ExampleSubClass8
   {
      public string example1 { get; set; }
      public List<string> listOfStrings { get; set; }
   }
}
