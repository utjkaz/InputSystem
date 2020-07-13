//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from XboxOneGampadMacOSWireless Layout
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
    public struct XboxOneGampadMacOSWirelessEvent : IInputData
    {
        public enum Id : uint
        {
            LeftStickX = 8,
            LeftStickY = 24,
            RightStickX = 40,
            RightStickY = 56,
            LeftTrigger = 72,
            RightTrigger = 88,
            DpadDown = 104,
            DpadUp = 104,
            DpadLeft = 104,
            DpadRight = 104,
            ButtonSouth = 112,
            ButtonEast = 113,
            ButtonWest = 115,
            ButtonNorth = 116,
            LeftShoulder = 118,
            RightShoulder = 119,
            Start = 123,
            LeftStickPress = 125,
            RightStickPress = 126,
            Select = 128,
        }

        private byte Padding0;
        public ushort LeftStickX;
        public ushort LeftStickY;
        public ushort RightStickX;
        public ushort RightStickY;
        public ushort LeftTrigger;
        public ushort RightTrigger;
        private int Padding1;
        private short Padding2;
        private byte Padding3;

        public unsafe bool ButtonSouth
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[14] & ((1 << 0) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[14] |= (1 << 0) & 0xFF;
                else
                    ((byte*)thisPtr)[14] &= ~(1 << 0) & 0xFF;
            }
        }

        public unsafe bool ButtonEast
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[14] & ((1 << 1) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[14] |= (1 << 1) & 0xFF;
                else
                    ((byte*)thisPtr)[14] &= ~(1 << 1) & 0xFF;
            }
        }

        public unsafe bool ButtonWest
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[14] & ((1 << 3) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[14] |= (1 << 3) & 0xFF;
                else
                    ((byte*)thisPtr)[14] &= ~(1 << 3) & 0xFF;
            }
        }

        public unsafe bool ButtonNorth
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[14] & ((1 << 4) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[14] |= (1 << 4) & 0xFF;
                else
                    ((byte*)thisPtr)[14] &= ~(1 << 4) & 0xFF;
            }
        }

        public unsafe bool LeftShoulder
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[14] & ((1 << 6) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[14] |= (1 << 6) & 0xFF;
                else
                    ((byte*)thisPtr)[14] &= ~(1 << 6) & 0xFF;
            }
        }

        public unsafe bool RightShoulder
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[14] & ((1 << 7) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[14] |= (1 << 7) & 0xFF;
                else
                    ((byte*)thisPtr)[14] &= ~(1 << 7) & 0xFF;
            }
        }

        public unsafe bool Start
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[15] & ((1 << 3) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[15] |= (1 << 3) & 0xFF;
                else
                    ((byte*)thisPtr)[15] &= ~(1 << 3) & 0xFF;
            }
        }

        public unsafe bool LeftStickPress
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[15] & ((1 << 5) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[15] |= (1 << 5) & 0xFF;
                else
                    ((byte*)thisPtr)[15] &= ~(1 << 5) & 0xFF;
            }
        }

        public unsafe bool RightStickPress
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[15] & ((1 << 6) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[15] |= (1 << 6) & 0xFF;
                else
                    ((byte*)thisPtr)[15] &= ~(1 << 6) & 0xFF;
            }
        }

        public unsafe bool Select
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[16] & ((1 << 0) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[16] |= (1 << 0) & 0xFF;
                else
                    ((byte*)thisPtr)[16] &= ~(1 << 0) & 0xFF;
            }
        }

        public uint Format => 22614969;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // XboxOneGampadMacOSWirelessEvent -> XboxOneGampadMacOSWirelessInput
                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.ButtonSouth
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.ButtonEast
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.ButtonWest
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.ButtonNorth
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.LeftShoulder
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.RightShoulder
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.Start
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.LeftStickPress
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.RightStickPress
                };
                transforms[9] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)XboxOneGampadMacOSWirelessInput.Id.Select
                };
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 22614969,
                    OutputFormat = 1614322207,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<XboxOneGampadMacOSWirelessEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<XboxOneGampadMacOSWirelessInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 10
                };

                // XboxOneGampadMacOSWirelessEvent -> XInputControllerInput
                transforms[10] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)XInputControllerInput.Id.ButtonSouth
                };
                transforms[11] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)XInputControllerInput.Id.ButtonEast
                };
                transforms[12] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)XInputControllerInput.Id.ButtonWest
                };
                transforms[13] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)XInputControllerInput.Id.ButtonNorth
                };
                transforms[14] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)XInputControllerInput.Id.LeftShoulder
                };
                transforms[15] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)XInputControllerInput.Id.RightShoulder
                };
                transforms[16] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)XInputControllerInput.Id.Start
                };
                transforms[17] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)XInputControllerInput.Id.LeftStickPress
                };
                transforms[18] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)XInputControllerInput.Id.RightStickPress
                };
                transforms[19] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)XInputControllerInput.Id.Select
                };
                structMappings[1] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 22614969,
                    OutputFormat = 3926081804,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<XboxOneGampadMacOSWirelessEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<XInputControllerInput>(),
                    TransformStartIndex = 10,
                    TransformCount = 10
                };

                // XboxOneGampadMacOSWirelessEvent -> GamepadInput
                transforms[20] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)GamepadInput.Id.ButtonSouth
                };
                transforms[21] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)GamepadInput.Id.ButtonEast
                };
                transforms[22] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)GamepadInput.Id.ButtonWest
                };
                transforms[23] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)GamepadInput.Id.ButtonNorth
                };
                transforms[24] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)GamepadInput.Id.LeftShoulder
                };
                transforms[25] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)GamepadInput.Id.RightShoulder
                };
                transforms[26] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)GamepadInput.Id.Start
                };
                transforms[27] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)GamepadInput.Id.LeftStickPress
                };
                transforms[28] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)GamepadInput.Id.RightStickPress
                };
                transforms[29] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)GamepadInput.Id.Select
                };
                structMappings[2] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 22614969,
                    OutputFormat = 623278190,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<XboxOneGampadMacOSWirelessEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<GamepadInput>(),
                    TransformStartIndex = 20,
                    TransformCount = 10
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 3;
        private const int kTransformCount = 30;
    }

    public struct XboxOneGampadMacOSWirelessInput : IComponentData, IInputData
    {
        public Float2Input LeftStick;
        public Float2Input RightStick;
        public Float2Input Dpad;
        public HalfAxisInput LeftTrigger;
        public HalfAxisInput RightTrigger;
        public HalfAxisInput LeftStickUp;
        public AxisInput LeftStickX;
        public AxisInput LeftStickY;
        public HalfAxisInput LeftStickDown;
        public HalfAxisInput LeftStickLeft;
        public HalfAxisInput LeftStickRight;
        public HalfAxisInput RightStickUp;
        public AxisInput RightStickX;
        public AxisInput RightStickY;
        public HalfAxisInput RightStickDown;
        public HalfAxisInput RightStickLeft;
        public HalfAxisInput RightStickRight;
        public FloatInput DpadX;
        public FloatInput DpadY;
        public HalfAxisInput DpadUp;
        public HalfAxisInput DpadDown;
        public HalfAxisInput DpadLeft;
        public HalfAxisInput DpadRight;
        public ButtonInput ButtonLeftTrigger;
        public ButtonInput ButtonRightTrigger;
        public ButtonInput Start;
        public ButtonInput Select;
        public ButtonInput LeftStickPress;
        public ButtonInput RightStickPress;
        public ButtonInput LeftShoulder;
        public ButtonInput RightShoulder;
        public ButtonInput ButtonSouth;
        public ButtonInput ButtonEast;
        public ButtonInput ButtonWest;
        public ButtonInput ButtonNorth;
        public ButtonInput ButtonLeftStickUp;
        public ButtonInput ButtonLeftStickDown;
        public ButtonInput ButtonLeftStickLeft;
        public ButtonInput ButtonLeftStickRight;
        public ButtonInput ButtonRightStickUp;
        public ButtonInput ButtonRightStickDown;
        public ButtonInput ButtonRightStickLeft;
        public ButtonInput ButtonRightStickRight;
        public ButtonInput ButtonDpadUp;
        public ButtonInput ButtonDpadDown;
        public ButtonInput ButtonDpadLeft;
        public ButtonInput ButtonDpadRight;

        public enum Id : uint
        {
            LeftStick = 0,
            RightStick = 64,
            Dpad = 128,
            LeftTrigger = 192,
            RightTrigger = 224,
            LeftStickUp = 256,
            LeftStickX = 288,
            LeftStickY = 320,
            LeftStickDown = 352,
            LeftStickLeft = 384,
            LeftStickRight = 416,
            RightStickUp = 448,
            RightStickX = 480,
            RightStickY = 512,
            RightStickDown = 544,
            RightStickLeft = 576,
            RightStickRight = 608,
            DpadX = 640,
            DpadY = 672,
            DpadUp = 704,
            DpadDown = 736,
            DpadLeft = 768,
            DpadRight = 800,
            ButtonLeftTrigger = 832,
            ButtonRightTrigger = 840,
            Start = 848,
            Select = 856,
            LeftStickPress = 864,
            RightStickPress = 872,
            LeftShoulder = 880,
            RightShoulder = 888,
            ButtonSouth = 896,
            ButtonEast = 904,
            ButtonWest = 912,
            ButtonNorth = 920,
            ButtonLeftStickUp = 928,
            ButtonLeftStickDown = 936,
            ButtonLeftStickLeft = 944,
            ButtonLeftStickRight = 952,
            ButtonRightStickUp = 960,
            ButtonRightStickDown = 968,
            ButtonRightStickLeft = 976,
            ButtonRightStickRight = 984,
            ButtonDpadUp = 992,
            ButtonDpadDown = 1000,
            ButtonDpadLeft = 1008,
            ButtonDpadRight = 1016,
        }
        public uint Format => 1614322207;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.LeftStickX,
                    InputId2 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStick
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.RightStickX,
                    InputId2 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStick
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.DpadX,
                    InputId2 = (uint)Id.DpadY,
                    OutputId = (uint)Id.Dpad
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStickUp
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickUp,
                    OutputId = (uint)Id.ButtonLeftStickUp
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStickDown
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickDown,
                    OutputId = (uint)Id.ButtonLeftStickDown
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)Id.LeftStickLeft
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickLeft,
                    OutputId = (uint)Id.ButtonLeftStickLeft
                };
                transforms[9] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)Id.LeftStickRight
                };
                transforms[10] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickRight,
                    OutputId = (uint)Id.ButtonLeftStickRight
                };
                transforms[11] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStickUp
                };
                transforms[12] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickUp,
                    OutputId = (uint)Id.ButtonRightStickUp
                };
                transforms[13] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStickDown
                };
                transforms[14] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickDown,
                    OutputId = (uint)Id.ButtonRightStickDown
                };
                transforms[15] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)Id.RightStickLeft
                };
                transforms[16] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickLeft,
                    OutputId = (uint)Id.ButtonRightStickLeft
                };
                transforms[17] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)Id.RightStickRight
                };
                transforms[18] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickRight,
                    OutputId = (uint)Id.ButtonRightStickRight
                };

                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1614322207,
                    OutputFormat = 1614322207,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<XboxOneGampadMacOSWirelessInput>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<XboxOneGampadMacOSWirelessInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 19
                };
                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 19;
    }
}