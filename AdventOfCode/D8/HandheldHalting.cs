namespace AdventOfCode.D8
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class HandheldHalting
    {
        public int GetAccumulatedValue(string text)
        {
            var program = Map(text);
            var processor = new Processor();
            var result = processor.Execute(program);

            return result.Accumulator;
        }

        public IEnumerable<Instruction> Map(string text)
        {
            return text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                       .Select(line =>
                       {
                           var instAndParam = line.Split(" ");
                           return Instruction.Build(instAndParam[0], instAndParam[1]);
                       });
        }
    }

    public class Processor
    {

        public ExecutionResult Execute(IEnumerable<Instruction> program)
        {
            
            var instructions = program as Instruction[] ?? program.ToArray();
            int instructionPointer = 0;
            int instructionCounter = 0;
            var context = new ExecutionContext(instructionPointer);
            Dictionary<int, int> pointerToCounter = new Dictionary<int, int>();
            Stack<KeyValuePair<int, Instruction>> stack = new Stack<KeyValuePair<int, Instruction>>();

            while (true)
            {
                var instruction = instructions.ElementAt(instructionPointer);

                stack.Push(new KeyValuePair<int, Instruction>(instructionPointer, instruction));

                if (pointerToCounter.ContainsKey(instructionPointer))
                {
                    return ExecutionResult.InfiniteLoop(context.Accumulator, stack);
                }

                instruction.Execute(context);
                instructionCounter++;

                pointerToCounter.Add(instructionPointer, instructionCounter);

                if (instruction == instructions.Last())
                {
                    return ExecutionResult.Ok(context.Accumulator, stack);
                }

                if (context.InstructionPointer == instructionPointer)
                {
                    context.InstructionPointer++;
                }

                instructionPointer = context.InstructionPointer;
            }
        }
    }

    public abstract class ExecutionResult
    {
        public int Accumulator { get; }

        public Stack<KeyValuePair<int, Instruction>> Stack { get; }

        protected ExecutionResult(int accumulator, Stack<KeyValuePair<int, Instruction>> stack)
        {
            Accumulator = accumulator;
            Stack = stack;
        }

        public static InfiniteLoopResult InfiniteLoop(int accumulator, Stack<KeyValuePair<int, Instruction>> stack)
        {
            return new InfiniteLoopResult(accumulator, stack);
        }

        public static OkResult Ok(int accumulator, Stack<KeyValuePair<int, Instruction>> stack)
        {
            return new OkResult(accumulator, stack);
        }

        public class InfiniteLoopResult : ExecutionResult {
            public InfiniteLoopResult(int accumulator, Stack<KeyValuePair<int, Instruction>> stack) : base(accumulator, stack)
            {
            }
        }

        public class OkResult : ExecutionResult {

            public OkResult(int accumulator, Stack<KeyValuePair<int, Instruction>> stack) : base(accumulator, stack)
            {
            }
        }
    }

    public class ExecutionContext
    {
        public ExecutionContext(int instructionPointer)
        {
            InstructionPointer = instructionPointer;
            Accumulator = 0;
        }

        public int InstructionPointer { get; set; }

        public int Accumulator { get; set; }
    }

    public abstract class Instruction
    {

        public static Instruction Build(string instruction, string parameter)
        {
            switch (instruction)
            {
                case "acc":
                    return new Acc(int.Parse(parameter, NumberStyles.AllowLeadingSign));

                case "jmp":
                    return new Jmp(int.Parse(parameter, NumberStyles.AllowLeadingSign));

                case "nop":
                    return new Nop();

                default:
                    throw new InvalidOperationException($"Unknown instruction : {instruction}");
            }
        }

        public abstract void Execute(ExecutionContext context);
    }

    public class Nop : Instruction
    {
        public override void Execute(ExecutionContext context)
        {
        }
    }

    public class Jmp : Instruction
    {
        private readonly int _offset;

        public Jmp(int offset)
        {
            _offset = offset;
        }

        public override void Execute(ExecutionContext context)
        {
            context.InstructionPointer += _offset;
        }
    }

    public class Acc : Instruction
    {
        private readonly int _value;

        public Acc(int value)
        {
            _value = value;
        }

        public override void Execute(ExecutionContext context)
        {
            context.Accumulator += _value;
        }
    }
}