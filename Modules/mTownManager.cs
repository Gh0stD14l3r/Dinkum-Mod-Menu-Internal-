using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dinkum.Modules
{
    class mTownManager
    {
        public static int TownDebt;

        public static void update()
        {
            if (NetworkMapSharer.share.townDebt != TownDebt)
            {
                TownDebt = NetworkMapSharer.share.townDebt;
            }
        }

        public static void payAllDebt()
        {
            TownManager.manage.payTownDebt(NetworkMapSharer.share.townDebt);
        }

        public static void townDonates(int donationTimes = 1)
        {
            for (int i = 0; i < donationTimes; i++)
            {
                TownManager.manage.townMembersDonate();
            }
        }

        public static void addTownBeautyToAll()
        {
            TownManager.manage.addTownBeauty(100f, TownManager.TownBeautyType.Decorations);
            TownManager.manage.addTownBeauty(100f, TownManager.TownBeautyType.Farms);
            TownManager.manage.addTownBeauty(100f, TownManager.TownBeautyType.Fence);
            TownManager.manage.addTownBeauty(100f, TownManager.TownBeautyType.Flowers);
            TownManager.manage.addTownBeauty(100f, TownManager.TownBeautyType.Path);
        }


    }
}
