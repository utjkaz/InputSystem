using ISX.LowLevel;
using UnityEngine;

////TODO: ideally, also take pointer DPI into account

namespace ISX.Processors
{
    public class SensitivityProcessor : IInputProcessor<Vector2>
    {
        public float sensitivity;

        public float sensitivityOrDefault
        {
            get { return sensitivity == 0f ? InputConfiguration.PointerDeltaSensitivity : sensitivity; }
        }

        public Vector2 Process(Vector2 value, InputControl control)
        {
            // Query dimensions of device.
            var dimensions = new Vector2(1f, 1f);
            var device = control.device;
            var command = QueryDimensionsCommand.Create();
            if (device.OnDeviceCommand(ref command) >= 0)
                dimensions = command.outDimensions;

            // Scale X and Y.
            var sensitivityValue = sensitivityOrDefault;
            return new Vector2(value.x / dimensions.x * sensitivityValue, value.y / dimensions.y * sensitivityValue);
        }
    }
}