using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TI.REGRA.NEGOCIOS
{
    public class ValidarRegraNegocios
    {
        public bool IsCpf(string cpf)
        {
            try
            {
                bool ret = TratarCpf(cpf);

                if (ret == false)
                {
                    return false;
                }
                else
                {
                    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    string tempCpf;
                    string digito;
                    int soma;
                    int resto;

                    cpf = cpf.Trim();
                    cpf = cpf.Replace(",", "").Replace("-", "");

                    if (cpf.Length != 11)
                        return false;

                    tempCpf = cpf.Substring(0, 9);
                    soma = 0;
                    for (int i = 0; i < 9; i++)
                        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                    resto = soma % 11;
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = resto.ToString();

                    tempCpf = tempCpf + digito;

                    soma = 0;
                    for (int i = 0; i < 10; i++)
                        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                    resto = soma % 11;
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = digito + resto.ToString();

                    return cpf.EndsWith(digito);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool TratarCpf(string cpf)
        {
            try
            {
                string um = "";
                string dois = "";
                string tres = "";
                string quatro = "";
                string cinco = "";
                string seis = "";
                string sete = "";
                string oito = "";
                string nove = "";
                string zero = "";

                um = um.PadLeft(11, '1');
                dois = dois.PadLeft(11, '2');
                tres = tres.PadLeft(11, '3');
                quatro = quatro.PadLeft(11, '4');
                cinco = cinco.PadLeft(11, '5');
                seis = seis.PadLeft(11, '6');
                sete = sete.PadLeft(11, '7');
                oito = oito.PadLeft(11, '8');
                nove = nove.PadLeft(11, '9');
                zero = zero.PadLeft(11, '0');

                if ((cpf.Trim() == um) || (cpf.Trim() == dois) || (cpf.Trim() == tres) || (cpf.Trim() == quatro) || (cpf.Trim() == cinco) || (cpf.Trim() == seis) || (cpf.Trim() == seis) || (cpf.Trim() == oito) || (cpf.Trim() == nove) || (cpf.Trim() == zero))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public bool IsCnpj(string cnpj)
        {
            try
            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                string digito;
                string tempCnpj;

                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

                if (cnpj.Length != 14)
                    return false;

                tempCnpj = cnpj.Substring(0, 12);

                soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();

                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cnpj.EndsWith(digito);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                if (Email.IndexOf("@", indexArr + 1) > 0)
                {
                    return ValidEmail;
                }

                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }

        public bool ValidarRg(string rg)
        {
            //Elimina da string os traços, pontos e virgulas,
            rg = rg.Replace("-", "").Replace(".", "").Replace(",", "").Replace(" ", "");

            //Verifica se o tamanho da string é 9
            if (rg.Length == 9)
            {
                int[] n = new int[8];

                //obtém cada um dos caracteres do rg
                n[0] = Convert.ToInt32(rg.Substring(0, 1));
                n[1] = Convert.ToInt32(rg.Substring(1, 1));
                n[2] = Convert.ToInt32(rg.Substring(2, 1));
                n[3] = Convert.ToInt32(rg.Substring(3, 1));
                n[4] = Convert.ToInt32(rg.Substring(4, 1));
                n[5] = Convert.ToInt32(rg.Substring(5, 1));
                n[6] = Convert.ToInt32(rg.Substring(6, 1));
                n[7] = Convert.ToInt32(rg.Substring(7, 1));
                n[8] = Convert.ToInt32(rg.Substring(8, 1));

                //Aplica a regra de validação do RG, multiplicando cada digito por valores pré-determinados
                n[0] *= 2;
                n[1] *= 3;
                n[2] *= 4;
                n[3] *= 5;
                n[4] *= 6;
                n[5] *= 7;
                n[6] *= 8;
                n[7] *= 9;
                n[8] *= 100;

                //Valida o RG
                int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7] + n[8];
                if ((somaFinal % 11) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public enum TipoCodigoBarras
        {
            NaoDefinido,
            EAN_8,
            EAN_13,
            GTIN_8,
            GTIN_12,
            GTIN_13,
            GTIN_14
        }

        public bool ValidarCodigoDeBarras(string CodigoBarras, TipoCodigoBarras TipoAValidar = TipoCodigoBarras.NaoDefinido)
        {
            string vCodigoBarras = CodigoBarras.Trim();

            if (string.IsNullOrEmpty(vCodigoBarras))
                return false;

            int AuxValorInt = int.MinValue; // <-- Variável auxiliar utilizada apenas para validar o TryParse

            switch (vCodigoBarras.Length)
            {
                case 8:
                    if (TipoAValidar != TipoCodigoBarras.EAN_8 && TipoAValidar != TipoCodigoBarras.NaoDefinido)
                        return false;

                    if (int.TryParse(vCodigoBarras.Substring(0, 7), out AuxValorInt)) // <-- Verifica se há somente números no código
                        if (vCodigoBarras[vCodigoBarras.Length - 1].ToString() == CalcularDigitoEAN8(vCodigoBarras.Substring(0, 7)))
                            return true;
                    break;

                case 13:
                    if (TipoAValidar != TipoCodigoBarras.EAN_13 && TipoAValidar != TipoCodigoBarras.NaoDefinido)
                        return false;

                    if (int.TryParse(vCodigoBarras.Substring(0, 12), out AuxValorInt)) // <-- Verifica se há somente números no código
                        if (vCodigoBarras[vCodigoBarras.Length - 1].ToString() == CalcularDigitoEAN13(vCodigoBarras.Substring(0, 12)))
                            return true;
                    break;
            }

            if (!TipoAValidar.ToString().ToUpper().Contains("GTIN") && TipoAValidar != TipoCodigoBarras.NaoDefinido)
                return false;

            if (ValidaCodigoGTIN(CodigoBarras))
                return true;
            return false;
        }

        public static string CalcularDigitoEAN13(string codigo)
        {
            int nPeso = 3;
            double nSoma = 0;
            double nMaior;
            int nDigito;

            string result = string.Empty;

            for (int nX = 11; nX >= 0; nX--)
            {
                nSoma = nSoma + int.Parse(codigo[nX].ToString()) * nPeso;

                if (nPeso == 3)
                    nPeso = 1;
                else
                    nPeso = 3;
            }

            nMaior = ((Math.Truncate(nSoma / 10) + 1) * 10);
            nDigito = Convert.ToInt32(Math.Truncate(nMaior) - Math.Truncate(nSoma));

            if (nDigito == 10)
                nDigito = 0;

            result = nDigito.ToString();

            return result;
        }

        public static string CalcularDigitoEAN8(string codigo)
        {
            int nPeso = 3;
            double nSoma = 0;
            double nMaior;
            int nDigito;

            string result = string.Empty;

            for (int nX = 6; nX >= 0; nX--)
            {
                nSoma = nSoma + int.Parse(codigo[nX].ToString()) * nPeso;

                if (nPeso == 3)
                    nPeso = 1;
                else
                    nPeso = 3;
            }

            nMaior = ((Math.Truncate(nSoma / 10) + 1) * 10);
            nDigito = Convert.ToInt32(Math.Truncate(nMaior) - Math.Truncate(nSoma));

            if (nDigito == 10)
                nDigito = 0;

            result = nDigito.ToString();

            return result;
        }

        private static bool ValidaCodigoGTIN(string codigoGTIN)
        {
            if (codigoGTIN != (new Regex("[^0-9]")).Replace(codigoGTIN, string.Empty))
                return false;

            switch (codigoGTIN.Length)
            {
                case 8:
                    codigoGTIN = "000000" + codigoGTIN;
                    break;
                case 12:
                    codigoGTIN = "00" + codigoGTIN;
                    break;
                case 13:
                    codigoGTIN = "0" + codigoGTIN;
                    break;
                case 14:
                    break;
                default:
                    return false;
            }

            //Calculando dígito verificador
            int[] a = new int[13];
            a[0] = int.Parse(codigoGTIN[0].ToString()) * 3;
            a[1] = int.Parse(codigoGTIN[1].ToString());
            a[2] = int.Parse(codigoGTIN[2].ToString()) * 3;
            a[3] = int.Parse(codigoGTIN[3].ToString());
            a[4] = int.Parse(codigoGTIN[4].ToString()) * 3;
            a[5] = int.Parse(codigoGTIN[5].ToString());
            a[6] = int.Parse(codigoGTIN[6].ToString()) * 3;
            a[7] = int.Parse(codigoGTIN[7].ToString());
            a[8] = int.Parse(codigoGTIN[8].ToString()) * 3;
            a[9] = int.Parse(codigoGTIN[9].ToString());
            a[10] = int.Parse(codigoGTIN[10].ToString()) * 3;
            a[11] = int.Parse(codigoGTIN[11].ToString());
            a[12] = int.Parse(codigoGTIN[12].ToString()) * 3;
            int sum = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] + a[11] + a[12];
            int check = (10 - (sum % 10)) % 10;

            //Checando
            int last = int.Parse(codigoGTIN[13].ToString());
            return check == last;
        }
    }
}
