using System;

namespace PrototypePattern
{
    public abstract class Shape : ICloneable
    {
        private string _id;
        protected string _entity;
        public abstract void Draw();

        public string GetId() 
        {
            return _id;
        }

        public string GetEntity()
        {
            return _entity;
        }

        public void SetId(string id) 
        {
            _id = id;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = MemberwiseClone();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return clone;
        }
    }
}
