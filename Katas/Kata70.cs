using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Katas.Kata70
{
    //This is the first part of this kata series. Second part is here.
    //We want to create a simple interpreter of assembler which will support the following instructions:
    //mov x y - copies y (either a constant value or the content of a register) into register x
    //inc x - increases the content of the register x by one
    //dec x - decreases the content of the register x by one
    //jnz x y - jumps to an instruction y steps away (positive means forward, negative means backward, y can be a register or a constant), but only if x (a constant or a register) is not zero
    //Register names are alphabetical (letters only). Constants are always integers (positive or negative).
    //Note: the jnz instruction moves relative to itself. For example, an offset of -1 would continue at the previous instruction, while an offset of 2 would skip over the next instruction.
    //The function will take an input list with the sequence of the program instructions and will execute them. The program ends when there are no more instructions to execute, then it returns a dictionary with the contents of the registers.
    //Also, every inc/dec/jnz on a register will always be preceeded by a mov on the register first, so you don't need to worry about uninitialized registers.
    //Example
    //SimpleAssembler.Interpret(new[] {"mov a 5","inc a","dec a","dec a","jnz a -1","inc a"});
    //''' visualized:
    //mov a 5
    //inc a
    //dec a
    //dec a
    //jnz a -1
    //inc a
    //''''
    //The above code will:
    //set register a to 5,
    //increase its value by 1,
    //decrease its value by 2,
    //then decrease its value until it is zero(jnz a -1 jumps to the previous instruction if a is not zero)
    //and then increase its value by 1, leaving register a at 1
    //So, the function should return
    //new Dictionary<string, int> { { "a" , 1 } };

    public interface IOperationAssembler
    {
        void Execute(Dictionary<string, int> data, ref int pointer);
    }
    public class MovOperation : IOperationAssembler
    {
        private string recipient;
        private string source;
        public MovOperation(string recipient, string source)
        {
            this.recipient = recipient;
            this.source = source;
        }
        private int GetValue(Dictionary<string, int> data, string source)
        {
            if (Int32.TryParse(source, out int result))
            {
                return result;
            }
            return data[source];
        }
        public void Execute(Dictionary<string, int> data, ref int pointer)
        {
            data[recipient] = GetValue(data, source);
        }
    }
    public class IncOperation : IOperationAssembler
    {
        private string operand;
        public IncOperation(string operand)
        {
            this.operand = operand;
        }
        public void Execute(Dictionary<string, int> data, ref int pointer)
        {
            data[operand] += 1;
        }
    }
    public class DecOperation : IOperationAssembler
    {
        private string operand;
        public DecOperation(string operand)
        {
            this.operand = operand;
        }
        public void Execute(Dictionary<string, int> data, ref int pointer)
        {
            data[operand] -= 1;
        }
    }
    public class JnzOperation : IOperationAssembler
    {
        private string operand;
        private int shift;
        public JnzOperation(string operand, int shift)
        {
            this.operand = operand;
            this.shift = shift;
        }
        public void Execute(Dictionary<string, int> data, ref int pointer)
        {
            if (Int32.TryParse(operand, out int result) && result != 0 || data.ContainsKey(operand) && data[operand] != 0)
            {
                pointer += shift - 1;
            }

        }
    }
    public static class SimpleAssembler
    {
        public static IOperationAssembler CreateInstance(string operation)
        {
            string[] dataForOperation = operation.Split(' ');
            switch (dataForOperation[0])
            {
                case "mov":
                    return new MovOperation(dataForOperation[1], dataForOperation[2]);
                case "inc":
                    return new IncOperation(dataForOperation[1]);
                case "dec":
                    return new DecOperation(dataForOperation[1]);
                default:
                    return new JnzOperation(dataForOperation[1], Convert.ToInt32(dataForOperation[2]));
            }
        }
        public static Dictionary<string, int> Interpret(string[] program)
        {
            IOperationAssembler[] operations = new IOperationAssembler[program.Length];
            for (int i = 0; i < program.Length; i++)
            {
                operations[i] = (CreateInstance(program[i]));
            }
            return ResultOperations(operations);
        }

        public static Dictionary<string, int> ResultOperations(IOperationAssembler[] operations)
        {
            Dictionary<string, int> registers = new Dictionary<string, int>();
            for (int i = 0; i < operations.Length; i++)
            {
                operations[i].Execute(registers, ref i);
            }
            return registers;
        }
    }

    [TestFixture, Description("Fixed tests")]
    public class FixedTests
    {
        private void Test(Dictionary<string, int> expected, Dictionary<string, int> actual)
        {
            var expectedStr = "{ " +
                              string.Join(", ", expected.Select(kv => $"{kv.Key}: {kv.Value}"))
                              + " }";
            var actualStr = "{ " +
                            string.Join(", ", actual.Select(kv => $"{kv.Key}: {kv.Value}"))
                            + " }";

            Assert.AreEqual(expected, actual, $"Expected: {expectedStr}, Actual: {actualStr}");
        }

        [Test, Description("Should work for some example programs")]
        public void ExamplePrograms()
        {
            Test(new Dictionary<string, int> { { "a", 1 } },
                SimpleAssembler.Interpret(new[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a" }));
            Test(new Dictionary<string, int> { { "a", 0 }, { "b", -20 } },
                SimpleAssembler.Interpret(new[] { "mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" }));
        }
    }
}

