using System;
using System.Collections.Generic;
using System.Text;

namespace PromedioNotasApp
{ 
    public class Alumno
    {
        private string nombreAlumno;
        private double nota1;
        private double nota2;
        private double nota3;
      
        public string GetNombreAlumno()
        {
            return nombreAlumno;
        }

        public void SetNombreAlumno(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;
        }       
        
        public void SetNota1(double nota1)
        {
            if (nota1 >= 0 && nota1 <= 5) this.nota1 = nota1;
            else this.nota1 = 0;
        }
                
        public void SetNota2(double nota2)
        {
            if (nota2 >= 0 && nota2 <= 5) this.nota2 = nota2;
            else this.nota2 = 0;
        }

        public void SetNota3(double nota3)
        {
            if (nota3 >= 0.0 && nota3 <= 5.0) this.nota3 = nota3;
            else this.nota3 = 0;
        }

        public double PromedioNotasAlumno()
        {
            return (this.nota1 + this.nota2+this.nota3) / 3;
        }
    }
}
