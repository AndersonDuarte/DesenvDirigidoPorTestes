using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Metodos
{
    SqlServer bd;
    public Metodos()
    {
        bd = new SqlServer();
    }
    public bool validaUsuario(string nomeUsuario)
    {
        return (bd.select(@"SELECT USUARIO FROM TABELA_POTZ WHERE USUARIO = '" + nomeUsuario + "'").Rows.Count != 0);
    }
    private string DigitoModulo11(string strCupom)
    {
        int[] intPesos = { 7, 6, 5, 4, 3, 2 };
        string strText = strCupom;
        
        int intSoma = 0;
        int intIdx = 0;
        for (int intPos = 0; intPos < strText.Length; intPos++, intIdx ++)
        {
            intSoma += Convert.ToInt32(strText[intPos].ToString()) * intPesos[intIdx];
        }
        int intResto = (intSoma % 11);
        string intDigito = Convert.ToString(11 - intResto);

        if (intDigito == "11")
            intDigito = "0";
        if (intDigito == "10")
            intDigito = "X";
      
        return intDigito;
    }
    /*
    public static string AddCheckDigit(string number)
    {
        int Sum = 0;
        for (int i = number.Length - 1, Multiplier = 2; i >= 0; i--)
        {
            Sum += (int)char.GetNumericValue(number[i]) * Multiplier;

            if (++Multiplier == 8) Multiplier = 2;
        }
        string Validator = (11 - (Sum % 11)).ToString();

        if (Validator == "11") Validator = "0";
        else if (Validator == "10") Validator = "X";

        return number + Validator;
    }*/
    public bool validaDigitoVerificador(string numeroCupom)
    {
        string codigo = numeroCupom.Substring(9, 1);
        string numero = DigitoModulo11(numeroCupom.Substring(3, 6));
        return (codigo == numero);
    }
    public bool validaQtdeCaracterCupom(string numeroCupom)
    {
        return (numeroCupom.Length == 11);
    }
    public bool validaQuantidadePontos(string numeroCupom)
    {
        int qtdePontos = quantidadePontos(numeroCupom);
        return qtdePontos != 0;
    }
    public int quantidadePontos(string numeroCupom)
    {
        int pontos = Convert.ToInt32(numeroCupom.Substring(0, 3));
        return pontos;
    }
}