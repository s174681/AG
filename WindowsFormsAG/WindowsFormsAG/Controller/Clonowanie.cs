using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace WindowsFormsAG.Controller
{
    public static class Clonowanie
    {
        //metoda genryczna rozszerzająca dla głębokiego kopiowania
        public static T DeepCopy<T>(T obj)
        {
            if (obj == null)
                
                throw new ArgumentNullException("Obiekt Nie może być null");
            
            return (T)Process(obj);
        }
        
        static object Process(object obj)
        {
            if (obj == null)
                
                return null;
            
            Type type = obj.GetType(); //jaki to obiekt
            
            if (type.IsValueType || type == typeof(string))
            {
                return obj;
            }
            else if (type.IsArray) //dla tablic
            {
                Type elementType = Type.GetType(type.FullName.Replace("[]", string.Empty));
                
                var array = obj as Array;
                
                Array copied = Array.CreateInstance(elementType, array.Length);
                
                for (int i = 0; i < array.Length; i++)
                {
                    copied.SetValue(Process(array.GetValue(i)), i);
                }

                return Convert.ChangeType(copied, obj.GetType());
            }
            else if (type.IsClass) //dla klass
            {
                object ret = Activator.CreateInstance(obj.GetType());

                //pobierz wszystkie pola klasy (właściwości, referencje klas, publiczne i prywatne 
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                
                //ustaw wartości dla nowych pól
                foreach (FieldInfo field in fields)
                {
                    object fieldValue = field.GetValue(obj);
                    
                    if (fieldValue == null)
                        
                        continue;
                    
                    field.SetValue(ret, Process(fieldValue));
                }
                return ret;
            }
            else
                throw new ArgumentException("Nie obsługiwany typ danych");
        }
    }
}
