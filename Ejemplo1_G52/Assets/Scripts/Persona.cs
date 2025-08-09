using UnityEngine;
using System;
namespace PackagesPersona
{

    [Serializable]
    public class Persona
    {

        private String nameP;
        private String mailP;
        private String dirP;

        public Persona()
        {
        }

        public Persona(string nameP, string mailP, string dirP)
        {
            this.nameP = nameP;
            this.mailP = mailP;
            this.dirP = dirP;
        }

        public string NameP { get => nameP; set => nameP = value; }
        public string MailP { get => mailP; set => mailP = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }
}
