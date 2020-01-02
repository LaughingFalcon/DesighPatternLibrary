using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interator
{
    public class Users: IEnumerable
    {
        private UserInfo[] _user;

        public Users(UserInfo[] uArray)
        {
            _user = new UserInfo[uArray.Length];



            for (int i = 0; i < uArray.Length; i++)
            {
                _user[i] = uArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();

        }

        public UsersEnum GetEnumerator()
        {
            return new UsersEnum(_user);

        }
    }
}
