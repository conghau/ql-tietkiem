using System;
using System.Collections.Generic;
using System.Text;

namespace TIETKIEM.Data.Entities
{
        public class EPHAN_QUYEN
        {
           public  EPHAN_QUYEN()
           {
           }
            private string _Ma_Quyen;
            private string _Ten_Quyen;


            public string Ma_Quyen
            {
                get { return _Ma_Quyen; }
                set { _Ma_Quyen = value; }
            }
            public string Ten_Quyen
            {
                get { return _Ten_Quyen; }
                set { _Ten_Quyen = value; }
            }
       }
}
