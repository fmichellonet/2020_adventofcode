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

            while (true)
            {
                var instruction = instructions.ElementAt(instructionPointer);

                if (pointerToCounter.ContainsKey(instructionPointer))
                {
                    return ExecutionResult.InfiniteLoop(context.Accumulator);
                }

                instruction.Execute(context);
                instructionCounter++;

                pointerToCounter.Add(instructionPointer, instructionCounter);

                if (instruction == instructions.Last())
                {
                    return ExecutionResult.Ok(context.Accumulator);
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
        protected int _accumulator;

        public int Accumulator => _accumulator;

        protected ExecutionResult(int accumulator)
        {
            _accumulator = accumulator;
        }

        public static InfiniteLoopResult InfiniteLoop(int accumulator)
        {
            return new InfiniteLoopResult(accumulator);
        }

        public static OkResult Ok(int accumulator)
        {
            return new OkResult(accumulator);
        }

        public class InfiniteLoopResult : ExecutionResult {
            public InfiniteLoopResult(int accumulator) : base(accumulator)
            {
            }
        }

        public class OkResult : ExecutionResult {
            public OkResult(int accumulator) : base(accumulator)
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