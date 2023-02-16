namespace CodeWars
{
    public class WorkArrays
    {
        #region Fields


        private Action<int[]> _Writer;
        private Func<int[]> _GetArray;
        private Func<int[], int[]> _Sorter;
        private Action<int[]> _Searcher;

        #endregion

        private int[] Array { get; set; }
        public Action<int[]> Writer { set => _Writer = value; }
        public Func<int[]> GetArray { set => _GetArray = value; }
        public Func<int[], int[]> Sorter { set => _Sorter = value; }
        public Action<int[]> Searcher { set => _Searcher = value; }


        //В будущем можно использовать паттерн строитель для инициализации этих полей      

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
                Array = _GetArray.Invoke();
                _Writer.Invoke(Array);
                Array = _Sorter.Invoke(Array);
                _Writer.Invoke(Array);
                _Searcher.Invoke(Array);
            }
            else return;

        }

        /// <summary>
        /// Метод который проверяет делегаты на содержание не null
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        private bool CheckingDelegatesNotNullContent()
        {
            if (_GetArray == null)
                throw new NullReferenceException($"Делегат {_GetArray.GetType().FullName} не содержит метод для вызова");

            if (_Sorter == null)
                throw new NullReferenceException($"Делегат {_Sorter.GetType().FullName} не содержит метод для вызова");

            if (_Writer == null)
                throw new NullReferenceException($"Делегат {_Writer.GetType().FullName} не содержит метод для вызова");

            if (_Searcher == null)
                throw new NullReferenceException($"Делегат {_Searcher.GetType().FullName} не содержит метод для вызова");

            return true;
        }

    }

}
