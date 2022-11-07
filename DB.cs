namespace UpdateDGVFromOtherForm
{
    internal class DB
    {
        private static List<user> datos = new List<user>();
        public static List<user> loaddatos()
        {
            datos.Add(new user { id = 1, name = "Alex", lastname = "Mora", age = 23, status = "active" });
            datos.Add(new user { id = 2, name = "Miriam", lastname = "Reyes", age = 33, status = "active" });
            datos.Add(new user { id = 3, name = "Bob", lastname = "Tuki", age = 45, status = "inactive" });
            datos.Add(new user { id = 4, name = "Carl", lastname = "Ika", age = 52, status = "active" });
            datos.Add(new user { id = 5, name = "Tere", lastname = "Maku", age = 39, status = "active" });
            return datos;
        }
    }
}