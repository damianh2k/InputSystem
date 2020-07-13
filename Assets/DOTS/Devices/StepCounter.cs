//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from StepCounter Layout
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Input;

#pragma warning disable CS0169

namespace Unity.Input
{
    public struct StepCounterEvent : IInputData
    {
        public enum Id : uint
        {
            StepCounter = 0,
        }

        public int StepCounter;

        public uint Format => 2531298077;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // StepCounterEvent -> StepCounterInput
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 2531298077,
                    OutputFormat = 4152427195,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<StepCounterEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<StepCounterInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 0
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 0;
    }

    public struct StepCounterInput : IComponentData, IInputData
    {
        public enum Id : uint
        {
        }
        public uint Format => 4152427195;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 0;
        private const int kTransformCount = 0;
    }
}