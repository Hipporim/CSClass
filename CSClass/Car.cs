using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        /// <summary>
        /// 자동차가 들어온 시간 설정
        /// </summary>
      
        internal void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차가 나온 시간 설정
        /// </summary>

        internal void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}
