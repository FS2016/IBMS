using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireAlarm
{
    class VideoInfo
    {
        //序号
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //终端
        private String term;

        public String Term
        {
            get { return term; }
            set { term = value; }
        }
        //描述
        private String desc;

        public String Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        //区域
        private String area;

        public String Area
        {
            get { return area; }
            set { area = value; }
        }
        //点位
        private String point;

        public String Point
        {
            get { return point; }
            set { point = value; }
        }

        private String guid;
        public String Guid {
            get { return guid; }
            set { guid = value; }
        }
    }
}
