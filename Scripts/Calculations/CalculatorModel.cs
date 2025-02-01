using Calculator.Scripts.Interface;
using Calculator.Scripts.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Scripts.Calculations
{
    public class CalculatorModel
    {
        private readonly Dictionary<string, IOperation> _operations = new();

        public CalculatorModel()
        {
            _operations["Add"] = new Addition();
            _operations["Subtract"] = new Subtraction();
            _operations["Multiply"] = new Multiplication();
            _operations["Divide"] = new Division();
        }

        public double PerformOperation(string operation, double num1, double num2)
        {
            if (_operations.ContainsKey(operation))
                return _operations[operation].Calculate(num1, num2);

            throw new InvalidOperationException("Invalid operation");
        }
    }
}
