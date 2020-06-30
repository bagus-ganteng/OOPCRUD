using System;
using System.Collections.Generic;
using System.Text;
using TugasOOP.Induk;

namespace TugasOOP.Anak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji() => GajiBulanan;
    }
}