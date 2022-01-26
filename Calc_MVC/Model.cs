using System.Collections.Generic;
using System.Windows.Controls;

namespace Calc_MVC
{
    class Model
    {
        private static List<string> operationsList = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        private static List<char> operationList = new List<char> { '+', '-', '*', '/' };

        private static byte index_operationList;
        private static double a;
        private static double b;

        public static double A
        {
            get { return a; }
            set
            {
                a = value;
            }
        }

        public static double B
        {
            get { return b; }
            set
            {
                b = value;
            }
        }

        public static double Sum
        {
            get { return a + b; }
        }

        public static double Sub
        {
            get { return a - b; }
        }

        public static double Mul
        {
            get { return a * b; }
        }

        public static double Del
        {
            get { return a / b; }
        }

        public static List<string> OperationsList
        {
            get { return operationsList; }
        }

        public static byte IndexOperationList
        {
            get { return index_operationList; }
            set
            {
                index_operationList = value;
            }
        }

        public static char OperationList
        {
            get { return operationList[index_operationList]; }
        }
    }
}