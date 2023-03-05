using AdapterPattern.Models;

namespace AdapterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            USBUSBCAdapter uSB_USBC_Adapter = new(new HardDrive());

            Console.WriteLine(uSB_USBC_Adapter.ReadData());
        }
    }
}
