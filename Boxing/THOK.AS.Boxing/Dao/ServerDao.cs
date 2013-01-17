using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using THOK.Util;

namespace THOK.AS.Boxing.Dao
{
    public class ServerDao : BaseDao
    {
        public DataTable FindAllUpLoadBatch()
        {
            string sql = string.Format(@"SELECT DISTINCT  
                                          CONVERT(varchar(10),ORDERDATE,120) + '|' + ltrim(STR(BATCHNO)) + '|' + LINECODE AS BATCHINFO, 
                                          CONVERT(varchar(10),ORDERDATE,120) + ' 第 ' + ltrim(STR(BATCHNO)) + ' 批次 ' + LINECODE + ' 号分拣线'  AS BATCHNAME 
                                          FROM AS_SC_CHANNELUSED
                                        WHERE LINECODE='03'");
            return ExecuteQuery(sql).Tables[0];
        }

        public DataTable FindOrderMaster(string orderDate, string batchNo, string lineCode)
        {
            string sql = string.Format(@"SELECT A.*,B.SORTID AS CUSTOMERSORTID,C.SORTID AS AREASORTID,D.SORTID AS ROUTESORTID FROM AS_SC_PALLETMASTER A
                                        LEFT JOIN AS_BI_CUSTOMER B ON A.CUSTOMERCODE=B.CUSTOMERCODE
                                        LEFT JOIN AS_BI_AREA C ON A.AREACODE=C.AREACODE
                                        LEFT JOIN AS_BI_ROUTE D ON A.ROUTECODE=D.ROUTECODE
                                        WHERE 
                                        ORDERDATE='{0}' AND BATCHNO='{1}' AND A.LINECODE='{2}' AND STATUS = '0'", orderDate, batchNo, lineCode);
            return ExecuteQuery(sql).Tables[0];
        }

        public DataTable FindBatch(string lineCode)
        {
            string sql = string.Format("SELECT  TOP 1 BATCHID,ORDERDATE,BATCHNO  FROM AS_BI_BATCH WHERE ISUPTONOONEPRO='1' AND " +
                "BATCHID NOT IN (SELECT BATCHID FROM AS_BI_BATCHSTATUS WHERE LINECODE='{0}') ORDER BY ORDERDATE,BATCHNO", lineCode);
            return ExecuteQuery(sql).Tables[0];
        }

        public DataTable FindOrder(string orderDate, string batchNo, string lineCode)
        {
            string sql = string.Format("SELECT * FROM AS_SC_ORDER WHERE ORDERDATE='{0}' AND BATCHNO={1} AND LINECODE='{2}'", orderDate, batchNo, lineCode);
            return ExecuteQuery(sql).Tables[0];
        }
    }
}
