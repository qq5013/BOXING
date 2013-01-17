using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using THOK.AS.Boxing.Dao;
using THOK.Util;

namespace THOK.AS.Boxing.Dal
{
    public class BoxDal
    {
        public DataTable GetOrderMaster()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BoxDao boxDao = new BoxDao();
                return boxDao.FindMaster();
            }
        }

        public DataTable GetOrderDetail(string sortNo)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BoxDao boxDao = new BoxDao();
                return boxDao.FindDetail(sortNo);
            }
        }

        public DataTable GetPackMaster()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BoxDao boxDao = new BoxDao();
                return boxDao.FindPackMaster();
            }
        }

        public DataTable GetPackDetail(string orderId)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BoxDao boxDao = new BoxDao();
                return boxDao.FindPackDetail(orderId);
            }
        }

        public DataTable GetCigarettes()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BoxDao boxDao = new BoxDao();
                return boxDao.FindCigarettes();
            }
        }

        public DataTable GetPackMaster(string[] filter)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BoxDao boxDao = new BoxDao();
                return boxDao.FindPackMaster(filter);
            }
        }
    }
}
