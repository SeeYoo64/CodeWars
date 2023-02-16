namespace CodeWars
{
    public class WorkArrays
    {
        #region Fields


        private readonly Action<int[]> Writer;
        private readonly Func<int[]> GetArray;
        private readonly Func<int[], int[]> Sorter;
        private readonly Action<int[]> Searcher;
        #endregion

        private int[] Array { get; set; }


        //В будущем можно использовать паттерн строитель для инициализации этих полей 
        public WorkArrays(Action<int[]> writer, Func<int[]> getArray, Func<int[], int[]> sorter, Action<int[]> searcher)
        {
            Writer = writer;
            GetArray = getArray;
            Sorter = sorter;
            Searcher = searcher;
        }


        /// <summary>
        ///    Метод который инкапсулирует в себе логику по работе с массивом, а именно:
        ///     1) Считывание массива из консоли
        ///     2) Сортировка массива
        ///     3) Вывод массива
        ///     4) Поиск числа и вывод этого искомого числа 
        /// </summary>
        public void OperationsOverArray()
        {
            if (CheckingDelegatesNotNullContent())
            {
                Array = GetArray.Invoke();
                Writer.Invoke(Array);
                Array = Sorter.Invoke(Array);
                Writer.Invoke(Array);
                Searcher.Invoke(Array);
            }
            else return;

        }

        /// <summary>
        /// Метод который проверяет делегаты на содержание не null
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        private bool CheckingDelegatesNotNullContent()
        {
            if (GetArray == null)
                throw new NullReferenceException($"Делегат {GetArray.GetType().FullName} не содержит метод для вызова");

            if (Sorter == null)
                throw new NullReferenceException($"Делегат {Sorter.GetType().FullName} не содержит метод для вызова");

            if (Writer == null)
                throw new NullReferenceException($"Делегат {Writer.GetType().FullName} не содержит метод для вызова");

            if (Searcher == null)
                throw new NullReferenceException($"Делегат {Searcher.GetType().FullName} не содержит метод для вызова");

            return true;
        }

    }

}
