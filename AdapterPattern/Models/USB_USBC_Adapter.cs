using AdapterPattern.Interfaces;

namespace AdapterPattern.Models
{
    public class USBUSBCAdapter : IPortAdapter
    {
        public HardDrive HardDrive { get; set; }
        public USBUSBCAdapter(HardDrive hardDrive)
        {
            HardDrive = hardDrive;
        }
        public string ReadData()
        {
            return HardDrive.ReadHardDriveData();
        }
    }
}