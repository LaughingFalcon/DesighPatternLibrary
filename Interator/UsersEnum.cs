using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interator
{
    public class UsersEnum : IEnumerator
    {
        public UserInfo[] _user;

        int currentIndex = -1;

        public UsersEnum(UserInfo[] list)
        {

            _user = list;

        }

        public bool MoveNext()
        {

            currentIndex++;
            return (currentIndex < _user.Length);

        }

        object IEnumerator.Current
        {

            get
            {
                return Current;

            }

        }

        public UserInfo Current
        {

            get
            {

                try
                {

                    return _user[currentIndex];

                }

                catch (IndexOutOfRangeException)
                {

                    throw new InvalidOperationException();

                }

            }

        }

        public void Reset()
        {

            currentIndex = -1;

        }
    }
}
