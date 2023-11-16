using System;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public interface IQrCodeScanner
    {
        Task<string> ScanQrCodeAsync();
    }
}