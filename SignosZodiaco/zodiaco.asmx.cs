using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SignosZodiaco
{
    /// <summary>
    /// Descripción breve de zodiaco
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class zodiaco : System.Web.Services.WebService
    {

        [WebMethod]
        public string signo(int dia, int mes)
        {
            var signo = "";

            if (mes != -1)
            {
                if (mes == 0) 
                {
                    if (dia <= 20)
                    {
                        signo = "Tu signo es  CAPRICORNIO ";
                    }
                    else
                    {
                        if (dia >= 21 && dia <= 31)
                        {
                            signo = "Tu signo es ACUARIO ";
                        }
                        else
                        {
                            signo = "Favor de Ingresar fecha exacta";
                        }
                    }
                }
                else
                {
                    if (mes == 1) 
                    {
                        if (dia <= 18)
                        {
                            signo = "Tu signo es ACUARIO ";
                        }
                        else
                        {
                            if (dia >= 19 && dia <= 29)
                            {
                                signo = "Tu signo es PISIS  ";
                            }
                            else
                            {
                                signo = "Favor de Ingresar fecha exacta";
                            }
                        }
                    }
                    else
                    {
                        if (mes == 2) 
                        {
                            if (dia <= 20)
                            {
                                signo = "Tu signo es PISIS ";
                            }
                            else
                            {
                                if (dia >= 21 && dia <= 31)
                                {
                                    signo = "Tu signo es ARIES  ";
                                }
                                else
                                {
                                    signo = "Favor de Ingresar fecha exacta";
                                }
                            }
                        }
                        else
                        {
                            if (mes == 3) 
                            {
                                if (dia <= 20)
                                {
                                    signo = "Tu signo es ARIES  ";
                                }
                                else
                                {
                                    if (dia >= 21 && dia <= 30)
                                    {
                                        signo = "Tu signo es TAURO ";
                                    }
                                    else
                                    {
                                        signo = "Favor de Ingresar fecha exacta";
                                    }
                                }
                            }
                            else
                            {
                                if (mes == 4) 
                                {
                                    if (dia <= 21)
                                    {
                                        signo = "Tu signo es TAURO ";
                                    }
                                    else
                                    {
                                        if (dia >= 22 && dia <= 31)
                                        {
                                            signo = "Tu signo es  GEMINIS";
                                        }
                                        else
                                        {
                                            signo = "Favor de Ingresar fecha exacta";
                                        }
                                    }
                                }
                                else
                                {
                                    if (mes == 5) 
                                    {
                                        if (dia <= 21)
                                        {
                                            signo = "Tu signo es GEMINIS ";
                                        }
                                        else
                                        {
                                            if (dia >= 22 && dia <= 30)
                                            {
                                                signo = "Tu signo es CANCER ";
                                            }
                                            else
                                            {
                                                signo = "Favor de Ingresar fecha exacta";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (mes == 6) 
                                        {
                                            if (dia <= 22)
                                            {
                                                signo = "Tu signo es CANCER";
                                            }
                                            else
                                            {
                                                if (dia >= 23 && dia <= 31)
                                                {
                                                    signo = "Tu signo es LEO ";
                                                }
                                                else
                                                {
                                                    signo = "Favor de Ingresar fecha exacta";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (mes == 7) 
                                            {
                                                if (dia <= 23)
                                                {
                                                    signo = "Tu signo es LEO ";
                                                }
                                                else
                                                {
                                                    if (dia >= 24 && dia <= 31)
                                                    {
                                                        signo = "Tu signo es VIRGO ";
                                                    }
                                                    else
                                                    {
                                                        signo = "Favor de Ingresar fecha exacta";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (mes == 8) 
                                                {
                                                    if (dia <= 23)
                                                    {
                                                        signo = "Tu signo es VIRGO \n Virgo";
                                                    }
                                                    else
                                                    {
                                                        if (dia >= 24 && dia <= 30)
                                                        {
                                                            signo = "Tu signo es LIBRA ";
                                                        }
                                                        else
                                                        {
                                                            signo = "Favor de Ingresar fecha exacta";
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (mes == 9) 
                                                    {
                                                        if (dia <= 23)
                                                        {
                                                            signo = "Tu signo es LIBRA ";
                                                        }
                                                        else
                                                        {
                                                            if (dia >= 24 && dia <= 31)
                                                            {
                                                                signo = "Tu signo es ESCORPION ";
                                                            }
                                                            else
                                                            {
                                                                signo = "Favor de Ingresar fecha exacta";
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (mes == 10) 
                                                        {
                                                            if (dia <= 22)
                                                            {
                                                                signo = "Tu signo es ESCORPION ";
                                                            }
                                                            else
                                                            {
                                                                if (dia >= 23 && dia <= 30)
                                                                {
                                                                    signo = "Tu signo es SAGITARIO  ";
                                                                }
                                                                else
                                                                {
                                                                    signo = "Favor de Ingresar fecha exacta";
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (mes == 11) 
                                                            {
                                                                if (dia <= 21)
                                                                {
                                                                    signo = "Tu signo es SAGITARIO  ";
                                                                }
                                                                else
                                                                {
                                                                    if (dia >= 22 && dia <= 31)
                                                                    {
                                                                        signo = "Tu signo es CAPRICORNIO ";
                                                                    }
                                                                    else
                                                                    {
                                                                        signo = "Favor de Ingresar fecha exacta";
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return signo;
        }
    }
}
