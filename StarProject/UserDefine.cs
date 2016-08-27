using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireAlarm
{
    static class UserDefine
    {
        private static int Log_Fail_Id = 0;
        private static int Log_Success_Id = 1;
        private static int Log_Get_Id = 2;
        private static int Log_Set_Id = 3;
        private static int Log_Alarm_Id = 4;

        private static int Log_Obix_Id = 0;

        private static int Log_Level_0 = 0;
        private static int Log_Level_1 = 1;
        private static int Log_Level_2 = 2;
        private static int Log_Level_3 = 3;
        private static int Log_Level_4 = 4;

        public static int FAIL_LOG
        {
            get { return Log_Fail_Id; }
        }
        public static int SUCCESS_LOG
        {
            get { return Log_Success_Id; }
        }
        public static int GET_LOG
        {
            get { return Log_Get_Id; }
        }
        public static int SET_LOG
        {
            get { return Log_Set_Id; }
        }
        public static int ALARM_LOG
        {
            get { return Log_Alarm_Id; }
        }

        public static int OBIX_LOG
        {
            get { return Log_Obix_Id; }
        }

        public static int LOG_LEVEL_0
        {
            get { return Log_Level_0; }
        }
        public static int LOG_LEVEL_1
        {
            get { return Log_Level_1; }
        }
        public static int LOG_LEVEL_2
        {
            get { return Log_Level_2; }
        }
        public static int LOG_LEVEL_3
        {
            get { return Log_Level_3; }
        }
        public static int LOG_LEVEL_4
        {
            get { return Log_Level_4; }
        }

    }
}
