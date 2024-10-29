using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class EnumerDemo
    {
        private int index = -1;
        private MemberInfomation[] member = new MemberInfomation[3];
        public EnumerDemo()
        {
            member[0] = new MemberInfomation { Name = "Orochi", Age = 24, ID = 1175 };
            member[1] = new MemberInfomation { Name = "Blinda", Age = 23, ID = 1265 };
            member[2] = new MemberInfomation { Name = "Ninicat", Age = 25, ID = 1295 };
        }

        #region IEnumerable
        //傳回會逐一查看集合的列舉程式。
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        #endregion

        #region IEnumerator
        //設定列舉值至它的初始位置，這是在集合中第一個元素之前。
        public void Reset()
        {
            index = -1;
        }

        //取得集合中目前的項目。
        public object Current
        {
            get { return member[index]; }
        }

        //將列舉值往前推至下集合中的下一個項目
        public bool MoveNext()
        {
            index++;
            return index >= member.Length ? false : true;
        }
        #endregion
    }
}
