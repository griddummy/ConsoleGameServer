using System;
using System.Collections.Generic;

namespace ConsoleGameServer
{
    public class RoomInfo
    {
        public const int MaxUser = 12;
        bool bWaiting;
        
        List<UserInfo> listUser;        

        public RoomInfo()
        {
            bWaiting = true;        
            listUser = new List<UserInfo>();
        }

        public bool AddGuest(UserInfo info)
        {
            if (listUser.Count >= MaxUser)
            {
                Log.instance.WriteLine("AddGuest::방에 사람이 모두 참", Log.Type.Fail);
                return false;
            }
            if(listUser.IndexOf(info) >= 0)
            {
                Log.instance.WriteLine("AddGuest::방에 이미 존재 함", Log.Type.Fail);
                return false;
            }
            listUser.Add(info);
            return true;
        }        
    }
}

