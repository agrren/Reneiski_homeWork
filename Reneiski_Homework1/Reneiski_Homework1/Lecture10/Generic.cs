namespace Reneiski_Homework1.Lecture10
{
    public class Generic<T> where T : Human
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public T[] array;

        public Generic(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Generic(int number)
        {
            array = new T[number];
        }

        public Generic()
        {
        }

        public List<Human> MyList { get; set; }

        public List<T> ArrToList(T[] array)
        {
            var list = array.ToList();
            return list;
        }

        public void AddElem(T[] array) // Добавление элементов
        {
            MyList.AddRange(array);
        }

        public void DeleteElem(Human item) // удаление элемента
        {
            MyList.Remove(item);
        }

        public Human GetElem(int index) // получение элемента
        {
            return MyList[index];
        }

        public int GetLength() // получение длинны
        {
            return MyList.Count();
        }

        public void ToString()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.FirstName);
            }

            if (typeof(T) == typeof(Man))
            {
                Console.WriteLine("There’re only men");
            }
            else
            {
                Console.WriteLine("There’re only women");
            }
        }
    }
}
