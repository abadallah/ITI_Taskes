using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.IO;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Swap(1,2);
            //Swap("string1","string2");

            //  DictinaryString();
            Mylist<int> sd = new Mylist<int>();
            sd.Add(1);
            sd.Add(2);
            sd.Add(3);
            sd.ForEach(a => { Console.WriteLine(a); });
            Console.ReadLine();
        }

        #region Swap
        static void Swap<T>(T val1,T val2)
        {

            Console.WriteLine("Genric Swap Fun");
            Console.WriteLine($"Before Swap My val1 : {val1} and val2 {val2}");
            T temp = val1;
            val1 = val2;
            val2 = temp;
            Console.WriteLine($"Before Swap My val1 : {val1} and val2 {val2}");
           
        }



        #endregion

        #region MyListNumber
        static void CreateList() {
            List<int> Listt = new List<int>();
            Listt.Add(1);
            Listt.Add(2);
            Listt.Add(3);
            Listt.Add(4);
            Listt.Add(5);
            int s = Listt.Sum();
            Console.WriteLine($"The sum is : {s}");

        }

        #endregion

        #region MyListString
        static void ListString()
        {

            List<String> MyStList = new List<string>();
            Console.WriteLine("Enter Names : ");
            string chek = "Y";
            do
            {
                MyStList.Add( Console.ReadLine());
                Console.Write("Enter Y to enter new name : ");
                chek = Console.ReadLine();


            } while (chek == "Y");

            Console.WriteLine("");
            Console.WriteLine("--------------------------");

            Console.WriteLine("You Enterd");
            MyStList.ForEach(a => { Console.WriteLine(a); });

            Console.WriteLine("");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Enter Order of elment to remove it");
            Console.WriteLine($"note the number shouid be between 1 and {MyStList.Count}");
            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= MyStList.Count)
            {
                MyStList.RemoveAt(index-1);
                MyStList.TrimExcess();


                Console.WriteLine("");
                Console.WriteLine("--------------------------");

                Console.WriteLine("new List");
                MyStList.ForEach(a => { Console.WriteLine(a); });

                Console.WriteLine("");
                Console.WriteLine("--------------------------");

            }
            else
            {
                Console.WriteLine("Invlide Number");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------");

        }
        #endregion


        #region MyDictinary
        static void DictinaryString()
        {

            Dictionary<int,String> MyStList = new Dictionary<int, String>();
            Console.WriteLine("Enter Names : ");
            string chek = "Y";
            int i = 0;
            do
            {
                MyStList.Add(i,Console.ReadLine());
                Console.Write("Enter Y to enter new name : ");
                chek = Console.ReadLine();
                i++;

            } while (chek == "Y");

            Console.WriteLine("");
            Console.WriteLine("--------------------------");

            Console.WriteLine("You Enterd");
            MyStList.ToList().ForEach(a => { Console.WriteLine($" Dic value : { a.Value} Dic Key : {a.Key}"); });

            Console.WriteLine("");
            Console.WriteLine("--------------------------");

          


        }
        #endregion
    }

    class Mylist<T> : List<T>
    {
        private const int _defaultCapacity = 4;
        internal const int MaxArrayLength = 0X7FEFFFFF;


        private T[] _items;
        [ContractPublicPropertyName("Count")]
        private int _size;
        private int _version;
        [NonSerialized]
        private Object _syncRoot;
        static readonly T[] _emptyArray = new T[0];

        public Mylist()
        {
            _items = _emptyArray;
        }
        public new void Add(T item)
        {

            if (_size == _items.Length) EnsureCapacity(_size + 1);
            _items[_size++] = item;
            _version++;
            try
            {

            

                FileStream fs1 = new FileStream("Mylist.txt", FileMode.Append, FileAccess.Write);

                StreamWriter s1 = new StreamWriter(fs1);

                s1.WriteLine("Value :  " +item);
                s1.Close();
                fs1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

      

        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {

                int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
                // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
                // Note that this check works even when _items.Length overflowed thanks to the (uint) cast
                if ((uint)newCapacity > MaxArrayLength) newCapacity = MaxArrayLength;
                if (newCapacity < min) newCapacity = min;
                Capacity = newCapacity;
            }
        }

        public new int Capacity
        {
            get
            {
                Contract.Ensures(Contract.Result<int>() >= 0);
                return _items.Length;
            }
            set
            {
                if (value < _size)
                {
                }
                Contract.EndContractBlock();

                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = _emptyArray;
                    }
                }
            }
        }

        public new void ForEach(Action<T> action)
        {
            if (action == null)
            {
            }
            Contract.EndContractBlock();

            int version = _version;

            for (int i = 0; i < _size; i++)
            {
                if (version != _version )
                {
                    break;
                }
                action(_items[i]);
            }

         
        }
    }
}
