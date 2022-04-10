namespace RecreatingSimpleList
{
    public class Lista<T>
    {
        public T[] lista = new T[4];
        public int Count { get; private set; }

        public void Sort()
        {
            for (int left = 0; lista[left] != null; left++)
            {
                T auxiliary;
                for (int right = left + 1; lista[right] != null; right++)
                {
                    if (lista[left].ToString().CompareTo(lista[right].ToString()) > 0)
                    {
                        auxiliary = lista[left];
                        lista[left] = lista[right];
                        lista[right] = auxiliary;
                    }
                }
            }
        }

        public T Add(T entity)
        {
            for (int i = 0; i <= Count; i++)
            {
                if (i == Count)
                {
                    Insert(i + 1, entity);
                    break;
                }
                else if (lista[i] == null)
                {
                    Insert(i, entity);
                    break;
                }
            }
            return entity;
        }

        public void Insert(int index, T item)
        {
            if (index > lista.Length - 1)
                Recreate();

            Count++;
            lista[index] = item;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                if (Equals(lista[i], item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void RemoveAt(int index)
        {
            lista[index] = default(T);
            Count--;
        }

        public void Clear()
        {
            lista = null;
            Count = 0;
        }

        private void Recreate()
        {
            T[] aux = new T[lista.Length * 2];

            for (int i = 0; i < lista.Length; i++)
                aux[i] = lista[i];

            lista = aux;
        }

    }
}
