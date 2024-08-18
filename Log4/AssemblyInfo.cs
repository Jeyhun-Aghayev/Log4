using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4
{
    public class AssemblyInfo
    {
        /*AssemblyInfo.cs Faylında Log4net-i Konfiqurasiya Etmək
        Log4net konfiqurasiya faylını layihəyə tanıtmaq üçün AssemblyInfo.cs faylınıza aşağıdakı sətiri əlavə edin. Bu addım log4net-ə konfiqurasiya faylını izləməyi bildirir:
        */
        [assembly: log4net.Config.XmlConfigurator(Watch = true)]


        //Konfiqurasiya Faylının Yaradılması

    }
}
