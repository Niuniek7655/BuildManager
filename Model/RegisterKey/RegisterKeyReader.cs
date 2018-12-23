using Microsoft.Win32;
using Model.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Constans.ConstansValues;

namespace Model.RegisterKey
{
    public class RegisterKeyReader
    {
        public static string GetValueFromLocalMachineRegistry(string keyPath, string registerValueName)
        {
            using (var key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    var keyObject = key.GetValue(registerValueName);
                    if (keyObject != null)
                    {
                        var keyValue = keyObject.ToString();
                        if (!string.IsNullOrEmpty(keyValue))
                            keyValue = EncryptionService.Decrypt(keyValue, EncryptionPassword);

                        return keyValue;
                    }
                }
            }
            return string.Empty;
        }
    }
}
