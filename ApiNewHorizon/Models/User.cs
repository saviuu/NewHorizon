using System;

namespace ApiNewHorizon
{
    public class User
    {
        public User(){}

        public User(int id, string name, string cpf)
        {
            this.id = id;
            this.name = name;
            this.cpf = cpf;
        }

        public int id { get; }

        public String name { get; set; }

        public String cpf { get; set; }
    }
}
