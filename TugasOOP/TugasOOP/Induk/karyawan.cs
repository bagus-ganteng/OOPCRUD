using System;
using System.Collections.Generic;
using System.Text;

namespace TugasOOP.Induk
{
    abstract public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}