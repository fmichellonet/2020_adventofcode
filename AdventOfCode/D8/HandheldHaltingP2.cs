namespace AdventOfCode.D8
{
    using System.Linq;

    public class HandheldHaltingP2 : HandheldHalting
    {
        public int GetAccumulatedValueWithFixedBoot(string text)
        {
            var program = Map(text).ToList();
            var processor = new Processor();
            var result = processor.Execute(program);


            while (result.Stack.Count > 0)
            {
                result.Stack.Pop().Deconstruct(out var instructionPointer, out var instruction);

                Instruction[] patched = new Instruction[program.Count];
                program.CopyTo(patched);

                if (instruction.GetType().IsAssignableFrom(typeof(Acc)))
                {
                    continue;
                }

                if (instruction.GetType().IsAssignableFrom(typeof(Nop)))
                {
                    patched[instructionPointer] = new Jmp(0);
                }

                if (instruction.GetType().IsAssignableFrom(typeof(Jmp)))
                {
                    patched[instructionPointer] = new Nop();
                }

                var patchedResult = processor.Execute(patched);
                if (patchedResult.GetType().IsAssignableFrom(typeof(ExecutionResult.OkResult)))
                {
                    return patchedResult.Accumulator;
                }
            }

            return -1;
        }
    }
}