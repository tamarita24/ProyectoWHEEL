using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

using System.ComponentModel;
using System.Reflection;
using System;

namespace CapaDTO
{
    #region PersistentBase
    [Serializable]
    public abstract class IPersistentBase : IComparable, IPBase, IInnerTypes
    {
        #region Constructor()
        public IPersistentBase()
        {
            _isDeleted = _isNew = _isModified = _isBlocked = false;
            _id = 0;
        }
        #endregion

        public abstract bool IsEqual(IPersistentBase p);
        [XmlIgnore]
        public IPersistentBase Instance { get { return this; } }

        #region Propertyes

        #region Property IsDeleted

       
        public virtual bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        #endregion

        #region Property IsNew


        public virtual bool IsNew
        {
            get { return _isNew; }
            set { _isNew = value; }
        }
        #endregion

        #region Property IsModified

        [XmlAttribute]
        [DefaultValue(false)]
        public virtual bool IsModified
        {
            get { return _isModified; }
            set { _isModified = value; }
        }
        #endregion

        #region Property IsBlocked


        [DefaultValue(false)]
        public virtual bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; }
        }
        #endregion

        #region Property Id


        public virtual int Id
        {
            get { return _id; }
            set
            {
                if (value == _id)
                    return;
                _id = value;
                IsModified = true;
            }
        }
        #endregion

        #region Property TimeStamp

        public object TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }
        #endregion

        #region Property Creation Date
        public virtual DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        #endregion


        #region Property Tag

        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        #endregion

        #region Property IsActive

        public virtual bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        #endregion

        #endregion

        #region Members
        [NonSerialized()]
        public bool _isDeleted;
        [NonSerialized()]
        public bool _isNew;
        [NonSerialized()]
        public bool _isModified;
        [NonSerialized()]
        public bool _isBlocked;
        [NonSerialized()]
        public int _id;
        [NonSerialized()]
        public object _timeStamp;

        private object _tag;

        [NonSerialized()]
        public bool _isActive;
        [NonSerialized()]
        public DateTime _creationDate;

        #endregion

        #region IComparable Members

        public int CompareTo(object obj)
        {
            Type tipo = GetType();
            MethodInfo mi = tipo.GetMethod("get_Nombre");
            if (mi == null)
                return 0;

            return string.Compare((string)mi.Invoke(this, null), (string)mi.Invoke(obj, null), false, System.Globalization.CultureInfo.InvariantCulture);
        }

        #endregion

        #region Method ToString()
        public override string ToString()
        {
            Type type = GetType();
            MethodInfo mi = type.GetMethod("get_Name");
            if (mi != null)
                return mi.Invoke(this, null) as string;
            mi = type.GetMethod("get_Description");
            if (mi != null)
                return mi.Invoke(this, null) as string;
            return base.ToString();
        }
        #endregion

        #region Method CompareIntArray(int[] array1, int[] array2)

        public static bool CompareIntArray(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                if (array2 != null)
                    return false;
                return true;
            }
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length; i++)
                if (array1[i] != array2[i])
                    return false;
            return true;
        }
        #endregion

        #region Method CloneIntArray(int[] array)
        public static int[] CloneIntArray(int[] array)
        {
            if (array == null)
                return null;
            int[] resultado = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                resultado[i] = array[i];
            return resultado;
        }
        #endregion

        #region Method CompareStringArray(string[] array1, string[] array2)
        public static bool CompareStringArray(string[] array1, string[] array2)
        {
            if (array1 == null)
            {
                if (array2 != null)
                    return false;
                return true;
            }
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length; i++)
                if (string.Compare(array1[i], array2[i], true, System.Globalization.CultureInfo.InvariantCulture) != 0)
                    return false;
            return true;
        }
        #endregion

        #region Method CloneStringArray(string[] array)
        public static string[] CloneStringArray(string[] array)
        {
            if (array == null)
                return null;
            string[] resultado = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
                resultado[i] = array[i] == null ? null : array[i].Clone() as string;
            return resultado;
        }
        #endregion

        #region Method CloneArrayList()
        public static ArrayList CloneArrayList(ArrayList array)
        {
            if (array == null)
                return null;
            ArrayList result = new ArrayList(array.Count);
            for (int i = 0; i < array.Count; i++)
                result.Add(array[i] == null ? null : array[i] is ICloneable ? ((ICloneable)array[i]).Clone() : null);
            return result;
        }
        #endregion

        #region Method ProperCase()
        public static string ProperCase(string s)
        {
            if (s == null) return null;
            s = s.Trim();
            s = s.ToLower();
            char[] seps = new char[] { ' ' };
            string[] strings = s.Split(seps);
            if (strings != null && strings.Length > 0 && strings[0].Length == 0)
                return string.Empty;
            if (strings == null || strings.Length == 0)
                return null;
            char[] chars = strings[0].ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            result.Append(chars);
            for (int i = 1; i < strings.Length; i++)
            {
                result.Append(' ');
                if (strings[i].Length > 0)
                {
                    chars = strings[i].ToCharArray();
                    chars[0] = char.ToUpper(chars[0]);
                    result.Append(chars);
                }
            }
            return result.ToString();
        }
        #endregion

        #region Method IsEmpty(string)
        protected bool IsEmpty(string value)
        {
            if (value == null || value.Length == 0) return true;
            return false;
        }
        #endregion

        #region IInnerTypes Members

        #region Method GetInnerTypes()
        /// <summary>
        /// Recorre los contenidos de this y va agregando a target cada tipo (System.Type) que encuentra.
        /// </summary>
        /// <param name="target">Lista de destino</param>
        public virtual void GetInnerTypes(IList target)
        {
            target.Add(GetType());
        }
        #endregion

        #region Property InnerTypes[]
        /// <summary>
        /// Retorna un arreglo de System.Type que contiene todos los tipos contenidos, sin repetidos.
        /// </summary>
        public virtual Type[] InnerTypes
        {
            get
            {
                IList list = new ArrayList();
                GetInnerTypes(list);
                if (list.Count == 0) return null;
                ArrayList result = new ArrayList();
                foreach (Type type in list)
                    if (!result.Contains(type))
                        result.Add(type);
                return (Type[])result.ToArray(typeof(Type));
            }
        }
        #endregion

        #region Method CreateSerializer()
        /// <summary>
        /// Crea el serializador que esta consciente de los tipos que debe manejar.
        /// </summary>
        /// <returns></returns>
        public virtual XmlSerializer CreateSerializer()
        {
            XmlSerializer serializer = new XmlSerializer(GetType(), InnerTypes);
            return serializer;
        }
        #endregion
        #region Method CreateBinaryFormatter()
        /// <summary>
        /// Crea el serializador binario.
        /// </summary>
        /// <returns></returns>
        public virtual BinaryFormatter CreateBinaryFormatter()
        {
            BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            return binaryFormatter;
        }
        #endregion



        #region Method CleanState()
        public virtual void CleanState()
        {
            _isNew = _isModified = _isDeleted = false;
        }
        #endregion

        #region Method CleanNull()
        public virtual void CleanNull()
        {
            if (_timeStamp is System.DBNull)
                _timeStamp = null;

        }
        #endregion

        #endregion
    }
    #endregion 

    #region Interface IInnerTypes
    /// <summary>
    /// Define un artefacto que es capaz de declarar qué tipos (System.Type) contiene directa o indirectamente.
    /// Se usa para poder consultar a un objeto como deserializarlo con un XmlSerializer.
    /// </summary>
    public interface IInnerTypes
    {
        void GetInnerTypes(IList target);
        Type[] InnerTypes { get; }
        XmlSerializer CreateSerializer();
        BinaryFormatter CreateBinaryFormatter();
    }
    #endregion

    #region Interface IPersistentBase
    /// <summary>
    /// Define la interfaz base para referirse a las entidades que pueden persistir en el sistema, es decir,
    /// ser almacenadas en un medio de almacenamiento y luego recuperadas tal como estaban antes.
    /// </summary>
    public interface IPBase
    {
        bool IsEqual(IPersistentBase p);
        int Id { get; set; }
        bool IsDeleted { get; set; }
        bool IsNew { get; set; }
        bool IsModified { get; set; }
        IPersistentBase Instance { get; }
        void CleanNull();
    }
    #endregion
}
